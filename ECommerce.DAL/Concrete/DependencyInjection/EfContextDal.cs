using ECommerce.DAL.Abstract;
using ECommerce.DAL.Concrete.EntityFramework;
using ECommerce.DAL.Concrete.EntityFramework.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DAL.Concrete.DependencyInjection
{
    public static class EfContextDal
    {
        public static void AddScopeDal(this IServiceCollection service)
        {
            service.AddScoped<IAddressDal, EfAddressDal>();
            service.AddScoped<IAuthorDal, EfAuthorDal>();
            service.AddScoped<IBookAuthorDal, BookAuthorDal>();
            service.AddScoped<IBookCategoryDal, EfBookCategoryDal>();
            service.AddScoped<IBookDal, EfBookDal>();
            service.AddScoped<IBookTranslatorDal, BookTranslatorDal>();
            service.AddScoped<ICampaignDal, EfCampaignDal>();
            service.AddScoped<ICartDal, EfCartDal>();
            service.AddScoped<ICartItemDal, EfCartItemDal>();
            service.AddScoped<ICategoryDal, EfCategoryDal>();
            service.AddScoped<ICityDal, EfCityDal>();
            service.AddScoped<ICountryDal, EfCountryDal>();
            service.AddScoped<ICoverTypeDal, EfCoverTypeDal>();
            service.AddScoped<ICreditCardInformationDal, CreditCardInformationDal>();
            service.AddScoped<ICustomerDal, EFCustomerDal>();
            service.AddScoped<IDiscountCouponDal, EfDiscountCouponDal>();
            service.AddScoped<IDistrictDal, EfDistrictDal>();
            service.AddScoped<IImageDal, EfImageDal>();
            service.AddScoped<ILanguageDal, EfLanguageDal>();
            service.AddScoped<IOrderDal, EfOrderDal>();            
            service.AddScoped<IPublisherDal, EfPublisherDal>();
            service.AddScoped<IShipperDal, EfShipperDal>();
            service.AddScoped<ITranslatorDal, EfTranslatorDal>();

        }
    }
}
