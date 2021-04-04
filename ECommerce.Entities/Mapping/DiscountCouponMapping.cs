using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class DiscountCouponMapping : IEntityTypeConfiguration<DiscountCoupon>
    {
        public void Configure(EntityTypeBuilder<DiscountCoupon> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y => y.CouponCode)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(y => y.Description)
                .HasColumnType("nvarchar")
                .HasMaxLength(1000);


            builder.HasMany(y => y.Carts)
                .WithOne(y => y.DiscountCoupon)
                .HasForeignKey(y => y.DiscountCouponID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
