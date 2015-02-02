using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class TransactionStatus
    {
        /// <summary>
        /// Describes transaction states (Unsigned, Signed, Submitted, Confirmed, Errored, Aborted
        /// </summary>
        public int TransactionStatusID { get; set; }
        public string TransactionStatusName { get; set; }

    }
}
