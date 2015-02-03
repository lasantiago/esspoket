using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Key]
        public int BankId { get; set; }

        [Required]
        public string BankName { get; set; }

        [Required]
        public Locality Locality { get; set; }
    }
}
