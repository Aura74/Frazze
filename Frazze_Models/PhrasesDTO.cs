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

        [Required(ErrorMessage = "Please enter a phrase..")]
        public string Phrase { get; set; }

        [Required(ErrorMessage = "Please enter a Culture..")]
        public string Culture { get; set; }
        public string? OrginalPhrase { get; set; }
        public string? PhraseDescription { get; set; }

        [Required(ErrorMessage = "Please enter an Element..")]
        public string Element { get; set; }
    }
}
