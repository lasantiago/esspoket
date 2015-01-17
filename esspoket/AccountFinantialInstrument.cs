using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
{
    public class AccountFinantialInstrument
    {
        public AccountFinantialInstrument()
        {

        }

        public Guid AccountFinantialInstrumentID { get; set; }

        public FinantialInstrumentType FinantialInstrumentType { get; set; }

        public Account Account { get; set; }        
    }
}
