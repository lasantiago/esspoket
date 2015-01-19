using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class Locality
    {
        public Locality()
        {
 
        }

        public int LocalityID { get; set; }

        public string LocalityName { get; set; }

        public Region Region { get; set; }
    }
}
