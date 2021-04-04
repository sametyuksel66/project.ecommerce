using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CartMapping : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();


            builder.HasMany(y => y.Orders)
                .WithOne(y => y.Cart)
                .HasForeignKey(y => y.CartID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.CartItems)
                .WithOne(y => y.Cart)
                .HasForeignKey(y => y.CartID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
