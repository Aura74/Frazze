using Frazze_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_Business.Repository.IRepository
{
    public interface IApplicationsRepository
    {
        public Task<ApplicationsDTO> Create(ApplicationsDTO objDTO);
        public Task<ApplicationsDTO> Update(ApplicationsDTO objDTO);
        public Task<int> Delete(int id);
        public Task<ApplicationsDTO> Get(int id);
        public Task<IEnumerable<ApplicationsDTO>> GetAll();
    }
}
