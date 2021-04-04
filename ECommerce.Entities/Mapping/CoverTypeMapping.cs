using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CoverTypeMapping : IEntityTypeConfiguration<CoverType>
    {

        public void Configure(EntityTypeBuilder<CoverType> builder)
        {

            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .HasMaxLength(20)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.HasMany(s => s.Books)
                .WithOne(s => s.CoverType)
                .HasForeignKey(s => s.CoverTypeID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
