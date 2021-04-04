using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Mapping
{ 
    public class CampaignMapping : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.HasKey(y => y.ID);
            builder.Property(y => y.ID)
                .ValueGeneratedOnAdd();

            builder.Property(y=>y.CampaignCode)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();


            builder.HasMany(y => y.Carts)
                .WithOne(y => y.Campaign)
                .HasForeignKey(y => y.CampaignID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
