using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ECommerce.Core.DataAccess.Abstract;

namespace ECommerce.DAL.Abstract
{
    public interface ICartItemDal:IEntityRepository<CartItem,int>
    {
    }
}
