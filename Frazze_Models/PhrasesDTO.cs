using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frazze_DataAccess;

namespace Frazze_Models
{
    public class PhrasesDTO
    {   public int PhraseID { get; set; }
        public string? Phrase { get; set; }
        //public string? Culture { get; set; }
        public string? OrginalPhrase { get; set; }
        public string? PhraseDescription { get; set; }
        public string? Element { get; set; }


        public int AppId { get; set; }
        public ApplicationsDTO Application { get; set; }

        public int CultId { get; set; }
        public CulturesDTO Cultures { get; set; }

        public int? PageId { get; set; }
        public PagesDTO? Pages { get; set; }
    }
}
