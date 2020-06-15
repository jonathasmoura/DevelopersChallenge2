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
        public BankRepository(BaseContext context)
        {
            _context = context;
        }
        public void Create(Bank bank)
        {
            _context.Banks.Add(bank);

        }

        public IEnumerable<Bank> GetAll()
        {
            var all = _context.Banks
            .ToList();
            return all;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
