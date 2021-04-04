using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    { 
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y => y.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(y => y.TotalPages)
                .HasColumnType("int");

            builder.Property(y => y.TotalPrinting)
                .HasColumnType("int");

            builder.Property(y => y.Price)
                .HasColumnType("money")
                .IsRequired();

            builder.Property(y => y.DiscountRate)
                .HasColumnType("float")
                .HasDefaultValue(0);

            builder.Property(y => y.TaxRate)
                .HasColumnType("float")
                .HasDefaultValue(0);

            builder.Property(y => y.MaterialType)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .HasDefaultValue("2.Hamur");

            builder.Property(y => y.PublicationDate)
                .HasColumnType("datetime");

            builder.Property(y => y.ISBN)
                .HasColumnType("nvarchar")
                .HasMaxLength(13)
                .IsRequired();

            builder.Property(y => y.Explanation)
                .HasColumnType("nvarchar")
                .HasMaxLength(1000);

            builder.Property(y => y.StockAmount)
                .HasColumnType("int")
                .HasDefaultValue(0);

            builder.Property(y => y.Ratings)
                .HasColumnType("float");



            builder.HasMany(y => y.BookTranslators)
                .WithOne(y => y.Book)
                .HasForeignKey(y=>y.BookID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.BookCategories)
                .WithOne(y => y.Book)
                .HasForeignKey(y=>y.BookID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.CartItems)
                .WithOne(y => y.Book)
                .HasForeignKey(y=>y.BookID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.Images)
                .WithOne(y => y.Book)
                .HasForeignKey(y=>y.BookID)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(y => y.BookAuthors)
                .WithOne(y => y.Book)
                .HasForeignKey(y=>y.BookID)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
