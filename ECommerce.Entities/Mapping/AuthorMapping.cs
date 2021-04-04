using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class AuthorMapping : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.FirstName)
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.Property(s => s.LastName)
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .IsRequired();

            builder.Property(s => s.About)
                .HasMaxLength(1000)
                .HasColumnType("nvarchar");

            builder.HasMany(s => s.BookAuthors)
                 .WithOne(s => s.Author)
                 .HasForeignKey(s => s.AuthorID)
                 .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
