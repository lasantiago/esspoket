using esspocketORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace esspocketAPI.Controllers
{
    public class TransactionsController : ApiController
    {
        Transaction c = new Transaction();

        public IEnumerable<Transaction> GetAllTransactions()
        {
            return c.GetAll(new EsspocketDBContext());
        }

        public Transaction GetTransactionById(string id)
        {
            return c.GetTransactionById(new EsspocketDBContext(), id);
        }
        
        public int SubmitTransaction(string relatedtransactionid, int transactionstateid, int transactiontypeid, string accountid, string details, double originalamount, double fee, double netamount, double currentbalance, bool iscurrentbalance)
        {
            return c.SubmitTransaction(new EsspocketDBContext(), relatedtransactionid, transactionstateid, transactiontypeid, accountid, details, originalamount, fee, netamount, currentbalance, iscurrentbalance);
        }
    }
}
