using System;
using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Infra.Contexts
{
    public class BaseContext : DbContext
    {

        public DbSet<Extract> ExtractOfxes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
    }
}
