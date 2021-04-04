using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(s => s.ID);
            builder.Property(s => s.ID)
                .ValueGeneratedOnAdd();

            builder.Property(s => s.Name)
                .HasMaxLength(30)
                .HasColumnType("nvarchar")
                .IsRequired();


            builder.HasMany(y => y.BookCategories)
                .WithOne(y => y.Category)
                .HasForeignKey(y => y.CategoryID);

            builder.HasOne(c => c.ParentCategory)
                .WithMany(pc => pc.SubCategory)
                .HasForeignKey(x => x.ParentCategoryId);
            
        }
    }
}
