using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Entities.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ECommerce.DAL.Concrete.EntityFramework.Contexts
{
    public class ECommerceDBContext:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionStringContainer.ConnectionString);
        }

        public DbSet<Address> Adresses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTranslator> BookTranslators { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<CreditCardInformation> CreditCardInformations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<DiscountCoupon> DiscountCoupons { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Translator> Translators { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMapping());
            modelBuilder.ApplyConfiguration(new AuthorMapping());
            modelBuilder.ApplyConfiguration(new BookAuthorMapping());
            modelBuilder.ApplyConfiguration(new BookCategoryMapping());
            modelBuilder.ApplyConfiguration(new BookMapping());
            modelBuilder.ApplyConfiguration(new BookTranslatorMapping());
            modelBuilder.ApplyConfiguration(new CampaignMapping());
            modelBuilder.ApplyConfiguration(new CartItemMapping());
            modelBuilder.ApplyConfiguration(new CartMapping());
            modelBuilder.ApplyConfiguration(new CategoryMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());
            modelBuilder.ApplyConfiguration(new CountryMapping());
            modelBuilder.ApplyConfiguration(new CoverTypeMapping());
            modelBuilder.ApplyConfiguration(new CreditCardInformationMapping());
            modelBuilder.ApplyConfiguration(new CustomerMapping());
            modelBuilder.ApplyConfiguration(new DiscountCouponMapping());
            modelBuilder.ApplyConfiguration(new DistrictMapping());
            modelBuilder.ApplyConfiguration(new ImageMapping());
            modelBuilder.ApplyConfiguration(new LanguageMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new PublisherMapping());
            modelBuilder.ApplyConfiguration(new ShipperMapping());
            modelBuilder.ApplyConfiguration(new TranslatorMapping());
                        
            base.OnModelCreating(modelBuilder);
        }
    }
}
