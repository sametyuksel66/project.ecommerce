using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CartItemMapping : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            builder.HasKey(y => new { y.CartID, y.BookID });

            builder.Property(y => y.Quantity)
                .HasColumnType("int");
        }
    }
}
