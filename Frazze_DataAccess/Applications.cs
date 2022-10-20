using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_DataAccess
{
    public class Applications
    {
        [Key]
        public int ApplicationID { get; set; }
        public string? ApplicationName { get; set; }
        public DateTime? created { get; set; }
    }
}
