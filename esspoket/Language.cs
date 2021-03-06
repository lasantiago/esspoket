﻿using System;
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
        public Guid LanguageId { get; set; }

        [Required]
        public string ISO6391 { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(15)]
        public string LanguageName { get; set; }

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

        public IEnumerable<Language> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Languages
                    select c);
        }

        public Language GetLanguageByLanguageId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Languages
                         where c.LanguageId == new Guid(id)
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

        public Language GetLanguageByName(EsspocketDBContext e, string name)
        {
            var query = (from c in e.Languages
                         where c.LanguageName == name
                         select c).FirstOrDefault();

            return query;
        }
    }
}
