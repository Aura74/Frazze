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
    public class ApplicationsRepository : IApplicationsRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public ApplicationsRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<ApplicationsDTO> Create(ApplicationsDTO objDTO)
        {
            var obj = _mapper.Map<ApplicationsDTO, Applications>(objDTO);
            var addedObj = _db.Application.Add(obj);
            await _db.SaveChangesAsync();
            return _mapper.Map<Applications, ApplicationsDTO>(addedObj.Entity);
        }

        public async Task<int> Delete(int id)
        {
            var obj = _db.Application.FirstOrDefault(u => u.ApplicationID==id);
            if (obj!=null)
            {
                _db.Application.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<ApplicationsDTO> Get(int id)
        {
            var obj = await _db.Application.FirstOrDefaultAsync(u => u.ApplicationID==id);
            if (obj!=null)
            {
                return _mapper.Map<Applications, ApplicationsDTO>(obj);
            }
            return new ApplicationsDTO();
        }

        public async Task<IEnumerable<ApplicationsDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<Applications>, IEnumerable<ApplicationsDTO>>(_db.Application);
        }

        public async Task<ApplicationsDTO> Update(ApplicationsDTO objDTO)
        {
            var objFromDb = await _db.Application.FirstOrDefaultAsync(u => u.ApplicationID==objDTO.ApplicationID);
            if (objFromDb!=null)
            {
                objFromDb.ApplicationID=objDTO.ApplicationID;
                objFromDb.ApplicationName=objDTO.ApplicationName;
                objFromDb.created=objDTO.created;


                _db.Application.Update(objFromDb);
                await _db.SaveChangesAsync();
                return _mapper.Map<Applications, ApplicationsDTO>(objFromDb);
            }
            return objDTO;
        }
    }
}
