using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class TransactionStatus
    {
        /// <summary>
        /// Describes transaction states (1- Unsigned, 2- Signed, 3- Submitted, 4- Confirmed, 5- Errored, 6- Aborted
        /// </summary>
        [Key]
        public int TransactionStatusId { get; set; }
        [Required]
        public string TransactionStatusName { get; set; }

        public IEnumerable<TransactionStatus> GetAll(EsspocketDBContext e)
        {
            return (from c in e.TransactionStatuses
                    orderby c.TransactionStatusId ascending
                    select c);
        }

        public TransactionStatus GetTransactionStatusById(EsspocketDBContext e, int id)
        {
            var query = (from c in e.TransactionStatuses
                         where c.TransactionStatusId == id
                         select c).FirstOrDefault();

            return query;
        }
    }
}
