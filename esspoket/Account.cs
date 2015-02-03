using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public Guid AccountId { get; set; }

        public AccountType AccountType { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // TODO: We would probably NOT use a password to access the account - STILL HAVE TO CHECK THIS
        public string Password { get; set; }
        public string PersonalDocumentId { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }
        public byte[] Photo { get; set; }
        public string Pin { get; set; }

        /// <summary>
        /// A 4 digit pin used in combination with the Pin and the primary phone number to create a private signing key for the account
        /// </summary>
        public string TransactionSigningPin { get; set; }

        [Required]
        public DateTime AccountCreationDate { get; set; }

        public string BusinessName { get; set; }

        public Guid BusinessAccountId { get; set; }

        public string TaxId { get; set; }

        public List<AccountAddress> AccountAddresses { get; set; }

        public List<AccountEmail> AccountEmails { get; set; }

        public List<AccountPhone> AccountPhones { get; set; }

        public Language AccountLanguage { get; set; }
    }

    public class AccountRepository
    {

        public IEnumerable<Account> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Accounts
                    orderby c.AccountCreationDate ascending
                    select c);
        }

        public Account GetAccountById(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Accounts
                         where c.AccountId == new Guid(id)
                         select c).FirstOrDefault();

            return query;
        }

        public Account GetAccountByPhoneNumber(EsspocketDBContext e, string phonenumber)
        {
            var query = (from c in e.Accounts
                         join d in e.AccountPhones on c.AccountId equals d.Account.AccountId
                         where d.AccountPhoneNumber == phonenumber
                         select c).FirstOrDefault();

            return query;
        }

        public Account GetAccountByEmail(EsspocketDBContext e, string email)
        {
            var query = (from c in e.Accounts
                         join d in e.AccountEmails on c.AccountId equals d.Account.AccountId
                         where d.Email == email
                         select c).FirstOrDefault();

            return query;
        }

        public double GetAccountCurrentBalanceByAccountId(EsspocketDBContext e, string id)
        {
            double query = (from c in e.Transactions
                            join d in e.Accounts on c.Account.AccountId equals d.AccountId
                            where c.IsCurrentBalance == true
                            select c.CurrentBalance).FirstOrDefault();

            return query;
        }

        public IEnumerable<Account> GetAccountsByLocalityId(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Accounts
                         join d in e.AccountAddresses on c.AccountId equals d.Account.AccountId
                         where d.Locality.LocalityId == id
                         select c);

            return query;
        }
    }
}
