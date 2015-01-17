using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        public Guid BankAccountID { get; set; }

        public AccountFinantialInstrument AccountFinantialInstrument { get; set; }
        public Bank Bank { get; set; }

        //TODO: BankAccountNumber MUST be encrypted
        public string BankAccountNumber { get; set; }

        public bool IsAccountActive { get; set; }

        public bool IsAccountValidated { get; set; }
    }
}
