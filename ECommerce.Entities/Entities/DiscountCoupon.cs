using ECommerce.Core.Entities;
using System.Collections.Generic;

namespace ECommerce.Entities.Entities
{
    public class DiscountCoupon:IEntity
    {
        public DiscountCoupon()
        {
            Carts = new HashSet<Cart>();
        } 
        public int ID { get; set; }
        public string CouponCode { get; set; }
        public string Description { get; set; }

        //nav
        public ICollection<Cart> Carts { get; set; }
    }
}