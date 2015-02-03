using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class PhoneType
    {
        public PhoneType()
        {

        }

        [Key]
        public int PhoneTypeId { get; set; }
        [Required]
        public string PhoneTypeName { get; set; }
    }
}
