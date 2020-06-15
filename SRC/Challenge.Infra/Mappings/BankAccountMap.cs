using System;
using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Infra.Mappings
{
    public class BankAccountMap : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            Ignores(builder);
            Properties(builder);
            Relationship(builder);
            builder.ToTable(nameof(BankAccount));
        }

        private void Relationship(EntityTypeBuilder<BankAccount> builder)
        {
            throw new NotImplementedException();
        }

        private void Properties(EntityTypeBuilder<BankAccount> builder)
        {
            throw new NotImplementedException();
        }

        private void Ignores(EntityTypeBuilder<BankAccount> builder)
        {
            throw new NotImplementedException();
        }
    }
}
