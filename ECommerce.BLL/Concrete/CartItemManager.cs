using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.BLL.Concrete
{
    public class CartItemManager : ICartItemService
    {
        ICartItemDal _cartItemDal;

        public CartItemManager(ICartItemDal cartItemDal)
        {
            _cartItemDal = cartItemDal;
        }

        public IResults Add(CartItem cartItem)
        {
            _cartItemDal.Add(cartItem);
            return new SuccessResult(Message.ProductAdded);


        }

        public IResults Delete(CartItem cartItem)
        {
            _cartItemDal.Delete(cartItem);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<List<CartItem>> GetList()
        {
            return new SuccessDataResult<List<CartItem>>(_cartItemDal.GetList().ToList());
        }

        public IDataResult<CartItem> GetCartItemByCartId(int cartId)
        {
            return new SuccessDataResult<CartItem>(_cartItemDal.Get(c => c.CartID == cartId));
        }

        public IResults Update(CartItem cartItem)
        {
            _cartItemDal.Update(cartItem);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
