using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
{
    public class CreditCard
    {
        public CreditCard()
        {

        }

        public Guid CreditCardID { get; set; }

        public AccountFinantialInstrument AccountFinantialInstrument { get; set; }
        public Bank Bank { get; set; }
        //TODO: Credit Card Number MUST be encrypted
        public string CreditCardNumber { get; set; }

        public bool IsCreditCardActive { get; set; }

        public bool IsCreditCardValidated { get; set; }
    
    }
}
