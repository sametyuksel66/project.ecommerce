using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class DistrictMapping : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y => y.Name)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(50);

            builder.HasMany(y => y.Addresses)
                .WithOne(y => y.District)
                .HasForeignKey(y => y.DistrictID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
