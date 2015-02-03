using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class CreditCard
    {
        public CreditCard()
        {

        }

        [Key]
        public Guid CreditCardId { get; set; }

        [Required]
        public AccountFinantialInstrument AccountFinantialInstrument { get; set; }
        
        [Required]
        public Bank Bank { get; set; }
        
        //TODO: Credit Card Number MUST be encrypted
        [Required]
        public string CreditCardNumber { get; set; }

        [Required]
        public bool IsCreditCardActive { get; set; }

        [Required]
        public bool IsCreditCardValidated { get; set; }
    
    }
}
