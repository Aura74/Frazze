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
    public class PagesRepository : IPagesRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public PagesRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<PagesDTO> Create(PagesDTO objDTO)
        {
            var obj = _mapper.Map<PagesDTO, Pages>(objDTO);
            var addedObj = _db.Page.Add(obj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Pages, PagesDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = _db.Page.FirstOrDefault(u => u.ID==id);
            if (obj!=null)
            {
                _db.Page.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<PagesDTO> Get(int id)
        {
            var obj = await _db.Page.FirstOrDefaultAsync(u => u.ID==id);
            if (obj!=null)
            {
                return _mapper.Map<Pages, PagesDTO>(obj);
            }
            return new PagesDTO();
        }

        public async Task<IEnumerable<PagesDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Pages>, IEnumerable<PagesDTO>>(_db.Page.Include(a => a.Application));
        }

        public async Task<PagesDTO> Update(PagesDTO objDTO)
        {
            var objFromDb = await _db.Page.FirstOrDefaultAsync(u => u.ID==objDTO.ID);
            if (objFromDb!=null)
            {
                //objFromDb.ID=objDTO.ID;
                objFromDb.PageName=objDTO.PageName;
                objFromDb.created=objDTO.created;
                objFromDb.ApplicationID=objDTO.ApplicationID;
                
                _db.Page.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Pages, PagesDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
