using Frazze_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazze_DataAccess;

namespace Frazze_Business.Repository.IRepository
{
    public interface ICulturesRepository
    {
        public Task<CulturesDTO> Create(CulturesDTO objDTO);
        public Task<CulturesDTO> Update(CulturesDTO objDTO);
        public Task<int> Delete(int id);
        public Task<CulturesDTO> Get(int id);
        public Task<IEnumerable<CulturesDTO>> GetAll();
    }
}
