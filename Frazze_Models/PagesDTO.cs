using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_Models
{
    public class PagesDTO
    {
        public int ID { get; set; }
        public string PageName { get; set; }
        //public int ApplicationID { get; set; }
        public DateTime created { get; set; }

        public int ApplicationID { get; set; }
        public ApplicationsDTO Application { get; set; }
    }
}
