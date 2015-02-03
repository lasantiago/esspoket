using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class AccountFinantialInstrument
    {
        public AccountFinantialInstrument()
        {

        }

        [Key]
        public Guid AccountFinantialInstrumentId { get; set; }

        [Required]
        public FinantialInstrumentType FinantialInstrumentType { get; set; }

        [Required]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }        
    }
}
