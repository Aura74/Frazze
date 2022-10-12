using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazze_Models;

namespace Frazze_Business.Repository.IRepository
{
    public interface IPhrasesRepository
    {
        public Task<PhrasesDTO> Create(PhrasesDTO objDTO);
        public Task<PhrasesDTO> Update(PhrasesDTO objDTO);
        public Task<int> Delete(int id);
        public Task<PhrasesDTO> Get(int id);
        public Task<IEnumerable<PhrasesDTO>> GetAll();
    }
}
