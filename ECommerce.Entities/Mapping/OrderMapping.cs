using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {

            builder.HasKey(o => o.ID);
            builder.Property(o => o.ID)
                .ValueGeneratedOnAdd();

            builder.Property(o => o.OrderDate)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(o => o.IsGiftPackage)
                .HasColumnType("bit")
                .HasDefaultValue(false);
            
            builder.Property(o => o.ShippingTrackingNumber)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();
            
            builder.Property(o => o.GiftNote)
                .HasMaxLength(1000)
                .HasColumnType("nvarchar");
            
            builder.Property(o => o.OrderStatus)
                .HasMaxLength(50)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.Property(o => o.PaymentType)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .IsRequired();



        }
    }
}
