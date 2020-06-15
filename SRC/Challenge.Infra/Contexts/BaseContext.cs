using System;
using Challenge.Domain.Entities;
using Challenge.Infra.Mappings;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Infra.Contexts
{
    public class BaseContext : DbContext
    {

        public BaseContext(DbContextOptions options)
        : base(options) { }
        public BaseContext() { }
        public DbSet<Extract> ExtractOfxes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Bank> Banks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BankMap());

            modelBuilder.Ignore<Notification>();
        }
    }
}
