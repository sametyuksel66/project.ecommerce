using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ECommerce.Entities.Entities;

namespace ECommerce.Entities.Mapping
{ 
    public class BookTranslatorMapping : IEntityTypeConfiguration<BookTranslator>
    {
        public void Configure(EntityTypeBuilder<BookTranslator> builder)
        {
            builder.HasKey(y => new {y.TranslatorID, y.BookID});
        }
    }
}
