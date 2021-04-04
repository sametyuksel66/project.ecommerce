using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.BLL.Concrete
{
    class CartManager : ICartService
    {
        private ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public IResults Add(Cart cart)
        {
                _cartDal.Add(cart);
                return new SuccessResult(Message.ProductAdded);         

        }

        public IResults Delete(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Cart> GetCartByUserId(int userId)
        {
            return new SuccessDataResult<Cart>(_cartDal.Get(o => o.ID == userId));
        }

        public IDataResult<List<Cart>> GetList()
        {
            return new SuccessDataResult<List<Cart>>(_cartDal.GetList().ToList());
        }

        public IResults Update(Cart cart)
        {
            _cartDal.Update(cart);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
