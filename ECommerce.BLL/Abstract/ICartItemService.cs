
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    interface ICartItemService
    {
        IResults Add(CartItem cartItem);

        IResults Delete(CartItem cartItem);
        IResults Update(CartItem cartItem);

        IDataResult<List<CartItem>> GetList();

        IDataResult<CartItem> GetCartItemByCartId(int cartId);
    }
}
