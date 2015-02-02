using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    class EsspocketDBContextSeeder: DropCreateDatabaseIfModelChanges<EsspocketDBContext>
    {
        protected override void Seed(EsspocketDBContext context)
        {

           
            base.Seed(context);
        }
    }
}
