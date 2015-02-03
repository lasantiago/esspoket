using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Gender
    {
        public Gender()
        {

        }
        /// <summary>
        /// Creates a new gender instance
        /// </summary>
        /// <param name="gendername">Name of the gender (ex.: "Male")</param>
        public Gender(string gendername)
        {
            this.GenderName = gendername;
        }

        [Key]
        public int GenderId { get; set; }

        [Required]
        public string GenderName { get; set; }

        public IEnumerable<Gender> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Genders
                    orderby c.GenderName ascending
                    select c);
        }

        public Gender GetGenderById(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Genders
                         where c.GenderId == id
                         select c).FirstOrDefault();

            return query;
        }
    }
}
