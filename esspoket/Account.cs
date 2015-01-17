using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
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

        public string Email { get; set; }

        public string Address { get; set; }

    }
}
