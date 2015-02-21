using esspocketORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace esspocketAPI.Controllers
{
    public class CountriesController : ApiController
    {
        Country c = new Country();
        public IEnumerable<Country> GetAllCountries()
        {
            return c.GetAll(new EsspocketDBContext());
        }

        public Country GetCountryById(string id)
        {
            return c.GetCountryById(new EsspocketDBContext(), id);
        }
    }
}
