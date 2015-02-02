namespace esspocketORM.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<esspocketORM.EsspocketDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(esspocketORM.EsspocketDBContext context)
        {
            Language l = new Language("es", "español");
            context.Languages.AddOrUpdate(l);

            Country c = new Country("República Dominicana");
            context.Countries.AddOrUpdate(c);
        }
    }
}
