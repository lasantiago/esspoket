using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
{
    public class AccountEmail
    {
        public AccountEmail()
        {

        }
        public Guid AccountEmailID { get; set; }
        public Account Account { get; set; }
        public EmailType EmailType { get; set; }
        public string Email { get; set; }
        public bool IsAccountEmailActive { get; set; }
        public bool IsAccountEmailValidated { get; set; }
        public bool IsPrimaryAccountEmail { get; set; }

    }
}
