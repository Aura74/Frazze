using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Frazze_Business.Repository.IRepository;
using Frazze_DataAccess.Data;
using Frazze_DataAccess;
using Frazze_Models;

namespace Frazze_Business.Repository
{
    public class PhrasesRepository : IPhrasesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PhrasesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<PhrasesDTO> Create(PhrasesDTO objDTO)
        {
            var obj = _mapper.Map<PhrasesDTO, Phrases>(objDTO);
            var addedObj = _db.Phrases.Add(obj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Phrases, PhrasesDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = _db.Phrases.FirstOrDefault(u => u.PhraseID==id);
            if (obj!=null)
            {
                _db.Phrases.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PhrasesDTO> Get(int id)
        {
            var obj = await _db.Phrases.FirstOrDefaultAsync(u => u.PhraseID==id);
            if (obj!=null)
            {
                return _mapper.Map<Phrases, PhrasesDTO>(obj);
            }
            return new PhrasesDTO();
        }

        public async Task<IEnumerable<PhrasesDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Phrases>, IEnumerable<PhrasesDTO>>(_db.Phrases.Include(u =>u.Cultures).Include(a => a.Application));
        }

        public async Task<PhrasesDTO> Update(PhrasesDTO objDTO)
        {
            var objFromDb = await _db.Phrases.FirstOrDefaultAsync(u => u.PhraseID==objDTO.PhraseID);
            if (objFromDb!=null)
            {
                objFromDb.Phrase=objDTO.Phrase; 
                //objFromDb.Culture=objDTO.Culture;
                objFromDb.OrginalPhrase=objDTO.OrginalPhrase;
                objFromDb.PhraseDescription=objDTO.PhraseDescription;
                objFromDb.Element=objDTO.Element;
                //objFromDb.AppId=objDTO.AppId;
                objFromDb.CultId=objDTO.CultId;

                _db.Phrases.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Phrases, PhrasesDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
