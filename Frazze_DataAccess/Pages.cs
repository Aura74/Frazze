using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_DataAccess
{
    public class Pages
    {
        public int ID { get; set; }
        public string PageName { get; set; }
        public int ApplicationID { get; set; }
        public DateTime created { get; set; }

    }
}
