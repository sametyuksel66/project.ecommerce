using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DTO.Concrete
{
    public class AddBookDto
    {
        public string Name { get; set; }
        public short TotalPage { get; set; }
        public int TotalPrinting { get; set; }
        public decimal Price { get; set; }
        public int DiscountRate { get; set; }
        public int TaxRate { get; set; }
        public string MaterialType { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string Explanation { get; set; }
        public int StockAmount { get; set; }
        public short Rate { get; set; }
        public string AuthorName { get; set; }
        public string AuthorLastName { get; set; }
        public byte[] Image { get; set; }
        public string TranslatorName { get; set; }
        public string TranslatorSurname { get; set; }
        public string TranslatorEmail { get; set; }
        public string Language { get; set; }
        public string PublisherName { get; set; }
        public string CoverTypeName { get; set; }



    }
}
