using System;
using System.Collections.Generic;
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
        public Guid AccountID { get; set; }
        public AccountType AccountType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        public string Pin { get; set; }

        public string BusinessName { get; set; }

        public Guid BusinessAccountID { get; set; }

        public string TaxID { get; set; }

        public Language AccountLanguage { get; set; }

    }
}
