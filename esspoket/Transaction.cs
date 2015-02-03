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
        public TransactionStatus TransactionStatus { get; set; }
        [Required]
        public TransactionType TransactionType { get; set; }
        [Required]
        public Account Account { get; set; }
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
    }
}
