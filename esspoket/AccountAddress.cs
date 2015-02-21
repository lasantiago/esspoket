using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace esspocketORM
{
    public class AccountAddress
    {
        public AccountAddress()
        {

        }

        [Key]
        public Guid AccountAddressId { get; set; }
        [Required]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public Guid AccountId { get; set; }


        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Building { get; set; }
        public string PremiseNumber { get; set; }

        [Required]
        [ForeignKey("LocalityId")]
        public Locality Locality { get; set; }

        public Guid LocalityId { get; set; }

        public string Postcode { get; set; }
        [Required]
        public bool IsAddressActive { get; set; }
        [Required]
        public bool IsAddressAproved { get; set; }

        [Required]
        public bool IsPrimaryAccountAddress { get; set; }

        public IEnumerable<AccountAddress> GetAll(EsspocketDBContext e)
        {
            return (from c in e.AccountAddresses
                    select c);
        }

        public AccountAddress GetAccountPrimaryAddressByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountAddresses
                         where c.Account.AccountId == new Guid(id)
                             & c.IsPrimaryAccountAddress == true
                         select c).FirstOrDefault();

            return query;
        }

        public IEnumerable<AccountAddress> GetAccountAddressesByAccountId(EsspocketDBContext e, string id)
        {
            var query = (from c in e.AccountAddresses
                         where c.Account.AccountId == new Guid(id)
                             select c);

            return query;
        }
    }
}
