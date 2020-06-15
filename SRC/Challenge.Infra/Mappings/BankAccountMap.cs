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


        private void Properties(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Id)
            .HasColumnName(nameof(BankAccount.Id))
            .IsRequired();

            builder.Property(entity => entity.AccountType)
            .HasColumnName(nameof(BankAccount.AccountType))
            .IsRequired();

            builder.Property(entity => entity.Agency)
            .HasColumnName(nameof(BankAccount.Agency))
            .IsRequired();

            builder.Property(entity => entity.BankId)
            .HasColumnName(nameof(BankAccount.BankId))
            .IsRequired();
        }

        private void Ignores(EntityTypeBuilder<BankAccount> builder)
        {
            builder.Ignore(entity => entity.Valid);
        }
        private void Relationship(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasOne(entity => entity.Bank)
            .WithMany(x => x.Accounts)
            .HasForeignKey(entity => entity.BankId);
        }
    }
}
