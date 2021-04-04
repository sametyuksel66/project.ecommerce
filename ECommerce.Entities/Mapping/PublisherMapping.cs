using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class PublisherMapping : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {

            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.HasMany(y => y.Books)
                .WithOne(y => y.Publisher)
                .HasForeignKey(y => y.PublisherID)
                .OnDelete(DeleteBehavior.Cascade);
 
        }
    }
}
