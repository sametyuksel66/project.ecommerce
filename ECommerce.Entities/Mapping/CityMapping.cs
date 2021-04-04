using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y => y.Name)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(y => y.Districts)
                .WithOne(y => y.City)
                .HasForeignKey(y => y.CityID)
                .OnDelete(DeleteBehavior.Cascade);
        }
        
    }
}
