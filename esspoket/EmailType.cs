using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class EmailType
    {
        public EmailType()
        {

        }

        [Key]
        public int EmailTypeID { get; set; }
        [Required]
        public string EmailTypeName { get; set; }
    }
}
