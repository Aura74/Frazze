using Frazze_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazze_DataAccess;

namespace Frazze_Business.Repository.IRepository
{

    public interface IPagesRepository
    {
        public Task<PagesDTO> Create(PagesDTO objDTO);
        public Task<PagesDTO> Update(PagesDTO objDTO);
        public Task<int> Delete(int id);
        public Task<PagesDTO> Get(int id);
        public Task<IEnumerable<PagesDTO>> GetAll();
    }
}
