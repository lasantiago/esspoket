using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class FinantialInstrumentType
    {
        public FinantialInstrumentType()
        {

        }

        [Key]
        public int FinantialInstrumentTypeID { get; set; }
        
        [Required]
        public string FinantialInstrumentName { get; set; }

    }
}
