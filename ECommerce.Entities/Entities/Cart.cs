using ECommerce.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Entities.Entities
{
    public class Cart : IEntity
    {
        public Cart()
        {
            CartItems = new HashSet<CartItem>();
            Orders = new HashSet<Order>();
        } 
        [ForeignKey("Customer")]
        public int ID { get; set; }
       
        public int CampaignID { get; set; }
        public int DiscountCouponID { get; set; }

        //nav
        public Campaign Campaign { get; set; }
        public DiscountCoupon DiscountCoupon { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}