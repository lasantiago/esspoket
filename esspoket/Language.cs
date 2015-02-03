using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public IEnumerable<Language> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Languages
                    select c);
        }

        public Language GetLanguageByLanguageId(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Languages
                         where c.LanguageId == id
                         select c).FirstOrDefault();

            return query;
        }
        public Language GetLanguageByISO(EsspocketDBContext e, string iso)
        {
            var query = (from c in e.Languages
                         where c.ISO6391 == iso
                         select c).FirstOrDefault();

            return query;
        }
    }
}
