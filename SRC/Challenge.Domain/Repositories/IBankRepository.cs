using System;
using System.Collections.Generic;
using Challenge.Domain.Entities;

namespace Challenge.Domain
{
    public interface IBankRepository
    {
        void Create(Bank bank);
        IEnumerable<Bank> GetAll();
        void Save();

    }
}


