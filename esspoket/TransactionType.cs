using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    /// <summary>
    /// Types of transaction (1- Debits, 2- Credits)
    /// </summary>
    public class TransactionType
    {
        public TransactionType()
        {

        }

        public TransactionType(string c)
        {
            this.TransactionTypeName = c;
        }

        [Key]
        public int TransactionTypeId { get; set; }

        [Required]
        public string TransactionTypeName { get; set; }
        
        public IEnumerable<TransactionType> GetAll(EsspocketDBContext e)
        {
            return (from c in e.TransactionTypes
                    orderby c.TransactionTypeId ascending
                    select c);
        }

        public TransactionType GetTransactionTypeById(EsspocketDBContext e, int id)
        {
            var query = (from c in e.TransactionTypes
                         where c.TransactionTypeId == id
                         select c).FirstOrDefault();

            return query;
        }
    }
}
