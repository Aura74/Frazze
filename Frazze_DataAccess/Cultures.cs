using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_DataAccess
{
    public class Cultures
    {
        [Key]
        public int CultureID { get; set; }
        public string? Culture { get; set; }
        public DateTime? created { get; set; }
    }
}
