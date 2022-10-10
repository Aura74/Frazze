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
        public PhrasesDTO Create(PhrasesDTO objDTO);
        public PhrasesDTO Update(PhrasesDTO objDTO);
        public int Delete(int id);
        public PhrasesDTO Get(int id);
        public IEnumerable<PhrasesDTO> GetAll();
    }
}
