using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_DataAccess
{
    public class Phrases
    {
        [Key]
        public int PhraseID { get; set; }
        public string? Phrase { get; set; }
        public string? Culture { get; set; }
        public string? OrginalPhrase { get; set; }
        public string? PhraseDescription { get; set; }
        public string? Element { get; set; }
        //public DateTime? created { get; set; }
        //public int? ApplicationID { get; set; }
        //public int? PageID { get; set; }
    }
}
