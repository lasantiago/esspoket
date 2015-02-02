using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Account
    {
        public Account()
        {
        }
        
        [Key]
        public Guid AccountID { get; set; }
        public AccountType AccountType { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // TODO: We would probably NOT use a password to access the account - STILL HAVE TO CHECK THIS
        public string Password { get; set; }
        public string PersonalDocumentId { get; set; }
        public DateTime? DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }
        public byte[] Photo { get; set; }
        public string Pin { get; set; }

        /// <summary>
        /// A 4 digit pin used in combination with the Pin and the primary phone number to create a private signing key for the account
        /// </summary>
        public string TransactionSigningPin { get; set; }

        public string BusinessName { get; set; }

        public Guid BusinessAccountID { get; set; }

        public string TaxID { get; set; }

        public List<AccountAddress> AccountAddresses { get; set; }

        public List<AccountEmail> AccountEmails { get; set; }

        public List<AccountPhone> AccountPhones { get; set; }

        public Language AccountLanguage { get; set; }
    }

    public class AccountRepository
    {
        public List<Account> GetAccounts()
        {
            EsspocketDBContext AccountDBContext = new EsspocketDBContext();
            return AccountDBContext.Accounts.ToList();
        }

        /// <summary>
        /// TODO: SET THE ACCOUNT ID
        /// </summary>
        /// <param name="AccountId"></param>
        /// <returns></returns>
        public List<Account> GetAccountById(Guid AccountId)
        {
            EsspocketDBContext AccountDBContext = new EsspocketDBContext();
            return null;
        }
    }
}
