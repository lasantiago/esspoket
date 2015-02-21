using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid RelatedTransactionId { get; set; }
        [Required]
        public DateTime TransactionDate { get; set; }
        
        [Required]
        [ForeignKey("TransactionStateId")]
        public TransactionState TransactionState { get; set; }

        public int TransactionStateId { get; set; }

        [Required]
        [ForeignKey("TransactionTypeId")]
        public TransactionType TransactionType { get; set; }

        public int TransactionTypeId { get; set; }
        
        [Required]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
        public Guid AccountId { get; set; }
        
        [Required]
        public string Details { get; set; }
        [Required]
        public double OriginalAmount { get; set; }
        [Required]
        public double Fee { get; set; }
        [Required]
        public double NetAmount { get; set; }
        [Required]
        public double CurrentBalance { get; set; }
        [Required]
        public bool IsCurrentBalance { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Transaction()
        {

        }

        public Transaction(string relatedtransactionid, int transactionstateid, int transactiontypeid, string accountid, string details, double originalamount, double fee, double netamount, double currentbalance, bool iscurrentbalance)
        {
            this.TransactionId = Guid.NewGuid();
            this.RelatedTransactionId = new Guid(relatedtransactionid);
            this.TransactionDate = DateTime.Now;
            this.TransactionStateId = transactionstateid;
            this.TransactionTypeId = transactiontypeid;
            this.AccountId = new Guid(accountid);
            this.Details = details;
            this.OriginalAmount = originalamount;
            this.Fee = fee;
            this.NetAmount = netamount;
            this.CurrentBalance = currentbalance;
            this.IsCurrentBalance = iscurrentbalance;
        }
        
        public IEnumerable<Transaction> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Transactions
                    orderby c.TransactionDate ascending
                    select c);
        }

        public Transaction GetTransactionById(EsspocketDBContext e, string id)
        {
            var query = (from c in e.Transactions
                         where c.TransactionId == new Guid(id)
                         select c).FirstOrDefault();

            return query;
        }

        public int SubmitTransaction(EsspocketDBContext e, string relatedtransactionid, int transactionstateid, int transactiontypeid, string accountid, string details, double originalamount, double fee, double netamount, double currentbalance, bool iscurrentbalance)
        {
            Transaction t = new Transaction(relatedtransactionid, transactionstateid, transactiontypeid, accountid, details, originalamount, fee, netamount, currentbalance, iscurrentbalance);

            e.Transactions.Add(t);
            return e.SaveChanges();
        }
    }
}
