using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
   public class CreditCardInformationMapping : IEntityTypeConfiguration<CreditCardInformation>
    {
        public void Configure(EntityTypeBuilder<CreditCardInformation> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .ValueGeneratedOnAdd();
            
            builder.Property(c => c.CardHolderName)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(100);
            
            builder.Property(c => c.CreditCardNumber)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(16)
                .IsFixedLength();
            
            builder.Property(c => c.ExpireMonth)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(2)
                .IsFixedLength();
            
            builder.Property(c => c.ExpireYear)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(2)
                .IsFixedLength();
            
            builder.Property(c => c.Cvv)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(3)
                .IsFixedLength();

            



        }
    }
}
