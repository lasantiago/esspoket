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
        public Guid GenderId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(15)]
        public string GenderName { get; set; }

        [Required(ErrorMessageResourceType = typeof(Localization.es_DO), ErrorMessageResourceName = "DateEnteredRequiredError")]
        [DataType(DataType.DateTime)]
        [Display(Name = "DateEntered", ResourceType = typeof(@Localization.es_DO), Description = "DateEnteredDescription")]
        public DateTime DateEntered { get; set; }

        [Required(ErrorMessageResourceType = typeof(Localization.es_DO), ErrorMessageResourceName = "DateModifiedRequiredError")]
        [DataType(DataType.DateTime)]
        [Display(Name = "DateModified", ResourceType = typeof(@Localization.es_DO), Description = "DateModifiedDescription")]
        public DateTime DateModified { get; set; }

        [Required(ErrorMessageResourceType = typeof(Localization.es_DO), ErrorMessageResourceName = "CreatedByUserIdRequiredError")]
        [DataType(DataType.Text)]
        [Display(Name = "CreatedByUserId", ResourceType = typeof(Localization.es_DO), Description = "CreatedByUserIdDescription")]
        public Guid CreatedByUserId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Localization.es_DO), ErrorMessageResourceName = "ModifiedByUserIdRequiredError")]
        [DataType(DataType.Text)]
        [Display(Name = "ModifiedByUserId", ResourceType = typeof(Localization.es_DO), Description = "ModifiedByUserIdDescription")]
        public Guid ModifiedByUserId { get; set; }

        [Required(ErrorMessageResourceType = typeof(Localization.es_DO), ErrorMessageResourceName = "AssignedToUserIdRequiredError")]
        [DataType(DataType.Text)]
        [Display(Name = "AssignedToUserId", ResourceType = typeof(Localization.es_DO), Description = "AssignedToUserIdDescription")]
        public Guid AssignedToUserId { get; set; }

        public IEnumerable<Gender> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Genders
                    orderby c.GenderName ascending
                    select c);
        }

        public Gender GetGenderById(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Genders
                         where c.GenderId == new Guid(id)
                         select c).FirstOrDefault();

            return query;
        }

        public Gender GetGenderByName(EsspocketDBContext e, string name)
        {
            var query = (from c in e.Genders
                         where c.GenderName == name
                         select c).FirstOrDefault();

            return query;
        }
    }
}
