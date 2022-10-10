using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public PhrasesDTO Create(PhrasesDTO objDTO)
        {
            var obj = _mapper.Map<PhrasesDTO, Phrases>(objDTO);
            var addedObj = _db.Phrases.Add(obj);
            _db.SaveChanges();
            return _mapper.Map<Phrases, PhrasesDTO>(addedObj.Entity);
        }

        public int Delete(int id)
        {
            var obj = _db.Phrases.FirstOrDefault(u => u.PhraseID==id);
            if (obj!=null)
            {
                _db.Phrases.Remove(obj);
                return _db.SaveChanges();
            }
            return 0;
        }

        public PhrasesDTO Get(int id)
        {
            var obj = _db.Phrases.FirstOrDefault(u => u.PhraseID==id);
            if (obj!=null)
            {
                return _mapper.Map<Phrases, PhrasesDTO>(obj);
            }
            return new PhrasesDTO();
        }

        public IEnumerable<PhrasesDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<Phrases>, IEnumerable<PhrasesDTO>>(_db.Phrases);
        }

        public PhrasesDTO Update(PhrasesDTO objDTO)
        {
            var objFromDb = _db.Phrases.FirstOrDefault(u => u.PhraseID==objDTO.PhraseID);
            if (objFromDb!=null)
            {
                objFromDb.Phrase=objDTO.Phrase;
                objFromDb.Culture=objDTO.Culture;
                objFromDb.OrginalPhrase=objDTO.OrginalPhrase;
                objFromDb.PhraseDescription=objDTO.PhraseDescription;
                objFromDb.Element=objDTO.Element;

                _db.Phrases.Update(objFromDb);
                _db.SaveChanges();
                return _mapper.Map<Phrases, PhrasesDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
