
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    interface ICartService
    {
        IResults Add(Cart cart);

        IResults Delete(Cart cart);
        IResults Update(Cart cart);

        IDataResult<List<Cart>> GetList();

        IDataResult<Cart> GetCartByUserId(int userId);

    }
}
