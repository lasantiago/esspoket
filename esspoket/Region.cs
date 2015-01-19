using System;
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

        public int RegionID { get; set; }

        public string RegionName { get; set; }

        public Country Country { get; set; }
    }
}
