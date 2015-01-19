using System;
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

        public Guid AccountPhoneID { get; set; }
        public Account Account { get; set; }
        public PhoneType PhoneType { get; set; }
        public string AccountPhoneNumber { get; set; }
        public bool IsAccountPhoneNumberActive { get; set; }
        public bool IsAccountPhoneNumberValidated { get; set; }
        
    }
}
