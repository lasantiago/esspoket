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
        [DataType(DataType.Text)]
        public string CountryName { get; set; }

        public Language Language { get; set; }

        public IEnumerable<Country> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Countries
                    orderby c.CountryName ascending
                    select c);
        }

        public Country GetCountryById(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Countries
                         where c.CountryId == id
                         select c).FirstOrDefault();

            return query;
        }

        public Country GetCountryByName(EsspocketDBContext e, string name)
        {
            var query = (from c in e.Countries
                         where c.CountryName == name
                         select c).FirstOrDefault();

            return query;
        }
    }
}
