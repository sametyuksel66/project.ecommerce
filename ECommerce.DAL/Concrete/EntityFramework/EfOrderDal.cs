using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Core.DataAccess.BaseClasses.EntityFramework;
using ECommerce.DAL.Abstract;
using ECommerce.DAL.Concrete.EntityFramework.Contexts;
using ECommerce.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.DAL.Concrete.EntityFramework
{
    public class EfOrderDal:EFRepositoryBase<Order, ECommerceDBContext,int>, IOrderDal
    {        
        
    }
}
