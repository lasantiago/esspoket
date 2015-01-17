using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspoket
{
    public class Transaction
    {
        public Guid TransactionID { get; set; }
        public Guid RelatedTransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
        public Account OriginatingAccount { get; set; }
        public Account DestinationAccount { get; set; }
        public string Details { get; set; }
        public double OriginalAmount { get; set; }
        public double Fee { get; set; }
        public double NetAmount { get; set; }
        public double CurrentBalance { get; set; }
        public bool IsCurrentBalance { get; set; }
    }
}
