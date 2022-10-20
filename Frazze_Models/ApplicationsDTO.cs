using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_Models
{
    public class ApplicationsDTO
    {
        public int ApplicationID { get; set; }
        public string? ApplicationName { get; set; }
        public DateTime? created { get; set; }
    }
}
