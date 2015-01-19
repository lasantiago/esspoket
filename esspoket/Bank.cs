using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Bank
    {
        public Bank()
        {

        }

        public int BankID { get; set; }

        public string BankName { get; set; }

        public Locality Locality { get; set; }
    }
}
