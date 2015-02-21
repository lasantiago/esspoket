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

        [Required]
        [ForeignKey("AccountTypeId")]
        public AccountType AccountType { get; set; }

        public Guid AccountTypeId { get; set; }


        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        // TODO: We would probably NOT use a password to access the account - STILL HAVE TO CHECK THIS
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [MaxLength(13)]
        public string PersonalDocumentId { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
        public Guid GenderId { get; set; }
        public byte[] Photo { get; set; }
        public string Pin { get; set; }

        /// <summary>
        /// A 4 digit pin used in combination with the Pin and the primary phone number to create a private signing key for the account
        /// </summary>
        public string TransactionSigningPin { get; set; }

        public string BusinessName { get; set; }

        public Guid BusinessAccountId { get; set; }

        public string TaxId { get; set; }

        public List<AccountAddress> AccountAddresses { get; set; }

        public List<AccountEmail> AccountEmails { get; set; }

        public List<AccountPhone> AccountPhones { get; set; }

        [Required]
        [ForeignKey("LanguageId")]
        public Language Language { get; set; }

        public Guid LanguageId { get; set; }

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


        public IEnumerable<Account> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Accounts
                    orderby c.DateEntered ascending
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

        public IEnumerable<Account> GetAccountsByLocalityId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Accounts
                         join d in e.AccountAddresses on c.AccountId equals d.Account.AccountId
                         where d.Locality.LocalityId == new Guid(id)
                         select c);

            return query;
        }
    }
}
