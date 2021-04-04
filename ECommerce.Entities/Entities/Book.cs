using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Book : IEntity
    {
        public Book()
        { 
            BookTranslators = new HashSet<BookTranslator>();
            BookCategories = new HashSet<BookCategory>();
            CartItems = new HashSet<CartItem>();
            Images = new HashSet<Image>();
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalPages { get; set; }
        public int TotalPrinting { get; set; }
        public decimal Price { get; set; }
        public float DiscountRate { get; set; }
        public float TaxRate { get; set; }
        public string MaterialType { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }
        public string Explanation { get; set; }
        public int StockAmount { get; set; }
        public float Ratings { get; set; }
        public int? PublisherID { get; set; }
        public int? CoverTypeID { get; set; }
        public int? LanguageID { get; set; }

        //nav
        public Publisher Publisher { get; set; }
        public CoverType CoverType { get; set; }
        public Language Language { get; set; }
        public ICollection<BookTranslator> BookTranslators { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }


    }
}
