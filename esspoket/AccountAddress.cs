using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class AccountAddress
    {
        public AccountAddress()
        {

        }

        [Key]
        public Guid AccountAddressID { get; set; }
        public Account Account { get; set; }

        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Building { get; set; }
        public string PremiseNumber { get; set; }
        public Locality Locality { get; set; }
        public string Postcode { get; set; }
        [Required]
        public bool IsAddressActive { get; set; }
        [Required]
        public bool IsAddressAproved { get; set; }
    }
}
