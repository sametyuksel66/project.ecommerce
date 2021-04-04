using ECommerce.Core.DataAccess.BaseClasses.EntityFramework;
using ECommerce.DAL.Abstract;
using ECommerce.DAL.Concrete.EntityFramework.Contexts;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DAL.Concrete
{
    class EfPublisherDal : EFRepositoryBase<Publisher, ECommerceDBContext, int>, IPublisherDal
    {
    }
}
