using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Region
    {
        public Region()
        {

        }

        public Region(string regioname, Country c)
        {
            this.RegionName = regioname;
            this.Country = c;

        }

        [Key]
        public int RegionId { get; set; }

        [Required]
        public string RegionName { get; set; }

        [Required]
        public Country Country { get; set; }
    }
}
