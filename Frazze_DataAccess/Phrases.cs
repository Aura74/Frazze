using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        //public string? Culture { get; set; }
        public string? OrginalPhrase { get; set; }
        public string? PhraseDescription { get; set; }
        public string? Element { get; set; }
        

        public int AppId { get; set; }
        [ForeignKey("AppId")]
        public Applications Application { get; set; }
        
        public int CultId { get; set; }
        [ForeignKey("CultId")]
        public Cultures Cultures { get; set; }

        //public int? PageId { get; set; }
        //[ForeignKey("PageId")]
        //public Pages? Pages { get; set; }
    }
}
