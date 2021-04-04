using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();
            
            builder.Property(y => y.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(y => y.Detail)
                .HasColumnType("nvarchar")
                .HasMaxLength(1000)
                .IsRequired();

            builder.Property(y => y.RecipientPhone)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
            
        }
    }
}
