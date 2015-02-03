using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        [Key]
        public Guid BankAccountId { get; set; }

        [Required]
        public AccountFinantialInstrument AccountFinantialInstrument { get; set; }
        public Bank Bank { get; set; }

        //TODO: BankAccountNumber MUST be encrypted
        [Required]
        public string BankAccountNumber { get; set; }

        [Required]
        public bool IsAccountActive { get; set; }

        [Required]
        public bool IsAccountValidated { get; set; }

        [Required]
        public bool IsPrimaryAccountBank { get; set; }


    }
}
