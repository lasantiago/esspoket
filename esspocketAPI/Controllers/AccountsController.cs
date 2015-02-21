using esspocketORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace esspocketAPI.Controllers
{
    public class AccountsController : ApiController
    {
        Account c = new Account();
        public IEnumerable<Account> GetAll()
        {
            return c.GetAll(new EsspocketDBContext());
        }

        public Account GetAccountById(string id)
        {
            return c.GetAccountById(new EsspocketDBContext(), id);
        }

        public Account GetAccountByPhoneNumber(string id)
        {
            return c.GetAccountByPhoneNumber(new EsspocketDBContext(), id);
        }

        public Account GetAccountByEmail(string id)
        {
            return c.GetAccountByEmail(new EsspocketDBContext(), id);
        }

        public double GetAccountCurrentBalanceByAccountId(string id)
        {
            return c.GetAccountCurrentBalanceByAccountId(new EsspocketDBContext(), id);
        }

        public IEnumerable<Account> GetAccountsByLocalityId(string id)
        {
            return c.GetAccountsByLocalityId(new EsspocketDBContext(), id);
        }
    }
}
