using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .ValueGeneratedOnAdd();

            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.Property(c => c.Telephone)
                .HasColumnType("nvarchar")
                .HasMaxLength(10);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.Property(c => c.Password)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.HasOne(y => y.Cart)
                .WithOne(y => y.Customer);

            builder.HasMany(y => y.Addresses)
                .WithOne(y => y.Customer)
                .HasForeignKey(y => y.CustomerID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.CreditCardInformations)
                .WithOne(y => y.Customer)
                .HasForeignKey(y => y.CustomerID)
                .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
