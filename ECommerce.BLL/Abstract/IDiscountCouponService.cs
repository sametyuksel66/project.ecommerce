
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IDiscountCouponService
    {
        IResults Add(DiscountCoupon discountCoupon);

        IResults Delete(DiscountCoupon discountCoupon);
        IResults Update(DiscountCoupon discountCoupon);

        IDataResult<List<DiscountCoupon>> GetList();

        IDataResult<DiscountCoupon> GetDiscountCouponById(int couponId);
    }
}
