using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class AccountType
    {
        public AccountType()
        {
        }
    
        public int AccountTypeID { get; set; }
        public string AccountName { get; set; }

    }
}
