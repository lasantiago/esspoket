using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class AccountPhone
    {
        public AccountPhone()
        {

        }

        [Key]
        public Guid AccountPhoneId { get; set; }
        [Required]
        public Account Account { get; set; }
        [Required]
        public PhoneType PhoneType { get; set; }
        [Required]
        public string AccountPhoneNumber { get; set; }
        [Required]
        public bool IsAccountPhoneNumberActive { get; set; }
        [Required]
        public bool IsAccountPhoneNumberValidated { get; set; }

        [Required]
        public bool IsAccountPrimaryPhoneNumber { get; set; }

        public IEnumerable<AccountPhone> GetAll(EsspocketDBContext e)
        {
            return (from c in e.AccountPhones
                    select c);
        }

        public AccountPhone GetIsAccountPrimaryPhoneNumberByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountPhones
                         where c.Account.AccountId == new Guid(id)
                             & c.IsAccountPrimaryPhoneNumber == true
                         select c).FirstOrDefault();

            return query;
        }

        public IEnumerable<AccountPhone> GetIsAccountPhoneNumberByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountPhones
                         where c.Account.AccountId == new Guid(id)
                         select c);

            return query;
        }
    }
}
