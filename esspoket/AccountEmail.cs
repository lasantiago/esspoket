using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace esspocketORM
{
    public class AccountEmail
    {
        public AccountEmail()
        {

        }
        [Key]
        public Guid AccountEmailId { get; set; }
        
        [Required]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public EmailType EmailType { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsAccountEmailActive { get; set; }
        [Required]
        public bool IsAccountEmailValidated { get; set; }
        [Required]
        public bool IsPrimaryAccountEmail { get; set; }

        public IEnumerable<AccountEmail> GetAll(EsspocketDBContext e)
        {
            return (from c in e.AccountEmails
                    select c);
        }

        public AccountEmail GetAccountPrimaryEmailAddressByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountEmails
                         where c.Account.AccountId == new Guid(id)
                             & c.IsPrimaryAccountEmail == true
                         select c).FirstOrDefault();

            return query;
        }

        public IEnumerable<AccountEmail> GetAccountEmailAddressesByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountEmails
                         where c.Account.AccountId == new Guid(id)
                         select c);

            return query;
        }
    }
}
