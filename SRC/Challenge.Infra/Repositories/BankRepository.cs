using System;
using System.Collections.Generic;
using System.Linq;
using Challenge.Domain;
using Challenge.Domain.Entities;
using Challenge.Infra.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Infra.Repositories
{
    public class BankRepository : IBankRepository
    {
        private readonly BaseContext _context;
        public void Create(Bank bank)
        {
            _context.Banks.Add(bank);
        }

        public IEnumerable<Bank> GetAll()
        {
            var all = _context.Banks
            .AsNoTracking()
            .Where(x => x.BankId != 0)
            .OrderBy(x => x.BankName);
            return all;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
