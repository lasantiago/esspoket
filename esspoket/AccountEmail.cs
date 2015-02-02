using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class AccountEmail
    {
        public AccountEmail()
        {

        }
        [Key]
        public Guid AccountEmailID { get; set; }
        public Account Account { get; set; }
        public EmailType EmailType { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsAccountEmailActive { get; set; }
        [Required]
        public bool IsAccountEmailValidated { get; set; }
        [Required]
        public bool IsPrimaryAccountEmail { get; set; }

    }
}
