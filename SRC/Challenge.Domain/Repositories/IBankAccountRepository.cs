using System;
using System.Collections.Generic;
using Challenge.Domain.Entities;

namespace Challenge.Domain
{
    public interface IBankAccountRepository
    {
        void Create(BankAccount bank);
        void Update(BankAccount bank);
        IEnumerable<BankAccount> GetAll();
        BankAccount GetById(Guid id);
        BankAccount Delete(Guid id);
        bool AccountExists(Guid id);
        void Save();

    }
}


