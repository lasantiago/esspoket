using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Key]
        public int LocalityId { get; set; }

        [Required]
        public string LocalityName { get; set; }

        [Required]
        public Region Region { get; set; }

        public IEnumerable<Locality> GetAll(EsspocketDBContext e)
        {
            return (from c in e.Localities
                    orderby c.LocalityName ascending
                    select c);
        }

        public Locality GetLocalityById(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Localities
                         where c.LocalityId == id
                         select c).FirstOrDefault();

            return query;
        }

        public IEnumerable<Locality> GetLocalitiesByRegionId(EsspocketDBContext e, int id)
        {
            var query = (from c in e.Localities
                         where c.Region.RegionId == id
                         select c);

            return query;
        }
    }
}
