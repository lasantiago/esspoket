using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Country
    {
        public Country()
        {
        }
        
        /// <summary>
        /// TODO: CREATE a way to insert a country with a corresponding db language for localization
        /// </summary>
        /// <param name="c"></param>
        public Country(string c)
        {
            this.CountryName = c;
            //this.Language = l;
        }

        [Key]
        public int CountryId { get; set; }

        [Required]
        public string CountryName { get; set; }

       // [ForeignKey("LanguageId")]
        public Language Language { get; set; }
    }
}
