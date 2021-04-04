using ECommerce.Core.DataAccess.BaseClasses.EntityFramework;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DAL.Concrete.EntityFramework.Contexts
{
    class EFCustomerDal : EFRepositoryBase<Customer, ECommerceDBContext,int>,ICustomerDal
    {
    }
}
