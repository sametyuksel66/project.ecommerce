using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class TranslatorMapping : IEntityTypeConfiguration<Translator>
    {
        public void Configure(EntityTypeBuilder<Translator> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y => y.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(y => y.Surname)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(y => y.EMail)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(y => y.About)
                .HasColumnType("nvarchar")
                .HasMaxLength(1000);

            builder.HasMany(y => y.BookTranslators)
                .WithOne(y => y.Translator)
                .HasForeignKey(y => y.TranslatorID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
