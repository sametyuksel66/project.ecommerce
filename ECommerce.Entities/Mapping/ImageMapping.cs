using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {

            builder.HasKey(c => c.ID);
            builder.Property(c => c.ID)
                .ValueGeneratedOnAdd();

            //builder.Property(c => c.URL)
            //    .HasColumnType("nvarchar")
            //    .IsRequired()
            //    .HasMaxLength(300);



            builder.Property(c => c.Name)
                .HasColumnType("nvarchar")
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(c => c.Road)
                .HasColumnType("varbinary")
                .HasMaxLength(1000)
                .IsRequired();


        }
    }
}
