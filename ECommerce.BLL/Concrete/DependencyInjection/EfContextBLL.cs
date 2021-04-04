using ECommerce.BLL.Abstract;
using ECommerce.DAL.Concrete.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Concrete.DependencyInjection
{
    public static class EfContextBLL
    {
        public static void AddScopeBLL(this IServiceCollection services)
        {
            services.AddScopeDal();
            services.AddScoped<IAddressService, AddressManager>();
            services.AddScoped<IAuthorBookService, AuthorBookManager>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IBookCategoryService, BookCategoryManager>();
            services.AddScoped<IBookService, BookManager>();
            services.AddScoped<IBookTranslatorService, BookTranslatorManager>();
            services.AddScoped<ICampignService, CampaignManager>();
            services.AddScoped<ICartItemService, CartItemManager>();
            services.AddScoped<ICartService, CartManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICoverTypeService, CoverTypeManager>();
            services.AddScoped<ICreditCartService, CreditCartManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IDiscountCouponService, DiscountCouponManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IImageService, ImageManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<IOrderService, OrderManager>();
            
            services.AddScoped<IPublisherService, PublisherManager>();
            services.AddScoped<IShipperService, ShipperManager>();
            services.AddScoped<ITranslatorService, TranslatorManager>();
        }
    }
}
