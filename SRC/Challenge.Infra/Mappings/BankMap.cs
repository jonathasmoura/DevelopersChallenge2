using System;
using Challenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Challenge.Infra.Mappings
{
    public class BankMap : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            Ignores(builder);
            Properties(builder);
            Relationship(builder);
            builder.ToTable(nameof(Bank));
        }


        private void Properties(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(entity => entity.Id);
            builder.Property(entity => entity.Id)
            .HasColumnName(nameof(Bank.Id))
            .IsRequired();

            builder.Property(entity => entity.IsActive)
            .HasColumnName(nameof(Bank.IsActive))
            .IsRequired()
            .HasDefaultValue(true);

            builder.Property(entity => entity.BankName)
            .HasColumnName(nameof(Bank.BankName))
            .IsRequired();

            builder.Property(entity => entity.ActivationDate)
            .HasColumnName(nameof(Bank.ActivationDate))
            .IsRequired(false)
            .HasDefaultValue(DateTime.UtcNow);

            builder.Property(entity => entity.InactivationDate)
            .HasColumnName(nameof(Bank.InactivationDate))
            .IsRequired(false)
            .HasDefaultValue(DateTime.UtcNow);


            builder.Property(entity => entity.Created)
            .HasColumnName(nameof(Bank.Created))
            .IsRequired()
            .HasDefaultValue(DateTime.UtcNow);
        }

        private void Ignores(EntityTypeBuilder<Bank> builder)
        {
            builder.Ignore(entity => entity.Valid);
        }
        private void Relationship(EntityTypeBuilder<Bank> builder)
        {
            throw new NotImplementedException();
        }
    }
}
