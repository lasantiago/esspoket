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
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(esspocketORM.EsspocketDBContext context)
        {
            //Language l = new Language("es", "español");
            //context.Languages.AddOrUpdate(l);

            //Country c = new Country("República Dominicana");
            //context.Countries.AddOrUpdate(c);
            //context.Countries.AddOrUpdate(c => c.CountryName, new Country { CountryName = "República Dominicana" });

            //Gender g1 = new Gender("Masculino");
            //Gender g2 = new Gender("Femenino");
            //context.Genders.AddOrUpdate(g1);
            //context.Genders.AddOrUpdate(g2);

            
            //string c = "República Dominicana";
            
//            context.Regions.AddOrUpdate(new Region("Altagracia", new Country().GetCountryByName(context, c)));
//            context.Regions.AddOrUpdate(new Region("Azua", new Country().GetCountryByName(context, c)));

            

//Bahoruco
//Barahona
//Dajabón
//Distrito Nacional
//Duarte
//El Seibo
//Elias Piña
//Espaillat
//Hato Mayor
//Hermanas Mirabal
//Independencia
//La Romana
//La Vega
//María Trinidad Sánchez
//Monseñor Nouel
//Monte Plata
//Montecristi
//Pedernales
//Peravia
//Puerto Plata
//Samaná
//San Cristóbal
//San José de Ocoa
//San Juan de la Maguana
//San Pedro de Macoris
//Sánchez Ramírez
//Santiago de los Caballeros
//Santiago Rodríguez
//Santo Domingo
//Valverde
            
            context.SaveChanges();
        }
    }
}
