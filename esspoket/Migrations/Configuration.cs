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
            //Language l = new Language("es", "espa�ol");
            //context.Languages.AddOrUpdate(l);

            //Country c = new Country("Rep�blica Dominicana");
            //context.Countries.AddOrUpdate(c);
            //context.Countries.AddOrUpdate(c => c.CountryName, new Country { CountryName = "Rep�blica Dominicana" });

            //Gender g1 = new Gender("Masculino");
            //Gender g2 = new Gender("Femenino");
            //context.Genders.AddOrUpdate(g1);
            //context.Genders.AddOrUpdate(g2);

            
            //string c = "Rep�blica Dominicana";
            
//            context.Regions.AddOrUpdate(new Region("Altagracia", new Country().GetCountryByName(context, c)));
//            context.Regions.AddOrUpdate(new Region("Azua", new Country().GetCountryByName(context, c)));

            

//Bahoruco
//Barahona
//Dajab�n
//Distrito Nacional
//Duarte
//El Seibo
//Elias Pi�a
//Espaillat
//Hato Mayor
//Hermanas Mirabal
//Independencia
//La Romana
//La Vega
//Mar�a Trinidad S�nchez
//Monse�or Nouel
//Monte Plata
//Montecristi
//Pedernales
//Peravia
//Puerto Plata
//Saman�
//San Crist�bal
//San Jos� de Ocoa
//San Juan de la Maguana
//San Pedro de Macoris
//S�nchez Ram�rez
//Santiago de los Caballeros
//Santiago Rodr�guez
//Santo Domingo
//Valverde
            
            context.SaveChanges();
        }
    }
}
