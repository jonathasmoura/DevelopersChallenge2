using System;
using System.Linq;
using Challenge.Domain;
using Challenge.Infra.Contexts;
using Challenge.Domain.Entities;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Infra.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly BaseContext _context;
        public BankAccountRepository(BaseContext context)
        {
            _context = context;
        }
        public bool AccountExists(Guid id)
        {
            var acc = _context.BankAccounts.Any(c => c.Id == id);
            return acc;
        }

        public void Create(BankAccount bankAccount)
        {
            _context.BankAccounts.Add(bankAccount);
        }

        public BankAccount Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccount> GetAll()
        {
            var all = _context.BankAccounts.AsNoTracking()
            .Include(c => c.Bank)
            .Where(x => x.IsActive == true);
            return all;
        }

        public BankAccount GetById(Guid id)
        {
            var acc = _context.BankAccounts
            .FirstOrDefault(x => x.Id == id);
            return acc;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(BankAccount acc)
        {
            _context.Entry<BankAccount>(acc).State = EntityState.Modified;
        }
    }
}
