using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazze_Models
{
    public class PhrasesDTO
    {   public int PhraseID { get; set; }
        public string Phrase { get; set; }
        public string Culture { get; set; }
        public string? OrginalPhrase { get; set; }
        public string? PhraseDescription { get; set; }
        public string Element { get; set; }
    }
}
