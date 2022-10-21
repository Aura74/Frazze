using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Frazze_Business.Repository.IRepository;
using Frazze_DataAccess;
using Frazze_DataAccess.Data;
using Frazze_Models;
using Microsoft.EntityFrameworkCore;

namespace Frazze_Business.Repository
{
    public class CulturesRepository : ICulturesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public CulturesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<CulturesDTO> Create(CulturesDTO objDTO)
        {
            var obj = _mapper.Map<CulturesDTO, Cultures>(objDTO);
            var addedObj = _db.Culture.Add(obj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Cultures, CulturesDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = _db.Culture.FirstOrDefault(u => u.CultureID==id);
            if (obj!=null)
            {
                _db.Culture.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<CulturesDTO> Get(int id)
        {
            var obj = await _db.Culture.FirstOrDefaultAsync(u => u.CultureID==id);
            if (obj!=null)
            {
                return _mapper.Map<Cultures, CulturesDTO>(obj);
            }
            return new CulturesDTO();
        }

        public async Task<IEnumerable<CulturesDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Cultures>, IEnumerable<CulturesDTO>>(_db.Culture);
        }

        public async Task<CulturesDTO> Update(CulturesDTO objDTO)
        {
            var objFromDb = await _db.Culture.FirstOrDefaultAsync(u => u.CultureID==objDTO.CultureID);
            if (objFromDb!=null)
            {
                objFromDb.CultureID=objDTO.CultureID;
                objFromDb.Culture=objDTO.Culture;
                objFromDb.created=objDTO.created;


                _db.Culture.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Cultures, CulturesDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
