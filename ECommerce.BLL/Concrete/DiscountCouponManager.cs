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
    public class DiscountCouponManager : IDiscountCouponService
    {
        IDiscountCouponDal _discountCouponDal;

        public DiscountCouponManager(IDiscountCouponDal discountCouponDal)
        {
            _discountCouponDal = discountCouponDal;
        }

        public IResults Add(DiscountCoupon discountCoupon)
        {
            _discountCouponDal.Add(discountCoupon);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(DiscountCoupon discountCoupon)
        {
            _discountCouponDal.Delete(discountCoupon);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<DiscountCoupon> GetDiscountCouponById(int couponId)
        {
            return new SuccessDataResult<DiscountCoupon>(_discountCouponDal.Get(d => d.ID == couponId));
        }

        public IDataResult<List<DiscountCoupon>> GetList()
        {
            return new SuccessDataResult<List<DiscountCoupon>>(_discountCouponDal.GetList().ToList());
        }

        public IResults Update(DiscountCoupon discountCoupon)
        {
            _discountCouponDal.Update(discountCoupon);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
