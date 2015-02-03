using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esspocketORM
{
    public class EsspocketDBContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        public DbSet<AccountAddress> AccountAddresses { get; set; }

        public DbSet<AccountPhone> AccountPhones { get; set; }

        public DbSet<AccountEmail> AccountEmails { get; set; }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Gender> Genders { get; set; }

        public DbSet<Locality> Localities { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<TransactionStatus> TransactionStatuses { get; set; }

        public DbSet<TransactionType> TransactionTypes { get; set; }

        public DbSet<Language> Languages { get; set; }

    }
}
