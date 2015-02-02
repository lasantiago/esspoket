using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Language
    {
        public Language()
        {

        }

        public Language(string ISO6391, string languagename)
        {
            this.ISO6391 = ISO6391;
            this.LanguageName = LanguageName;
        }
        [Key]
        public int LanguageId { get; set; }

        [Required]
        public string ISO6391 { get; set; }

        [Required]
        public string LanguageName { get; set; }	
    }

}
