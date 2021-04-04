using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class ShipperMapping : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .HasMaxLength(150)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.Property(s => s.ShippingPrice)
                .HasColumnType("money")
                .IsRequired();

            builder.HasMany(s => s.Orders)
                .WithOne(s => s.Shipper)
                .HasForeignKey(s => s.ShipperID)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
