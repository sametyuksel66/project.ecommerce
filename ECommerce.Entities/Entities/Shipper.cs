using ECommerce.Core.Entities;
using System.Collections.Generic;

namespace ECommerce.Entities.Entities
{
    public class Shipper : IEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal ShippingPrice { get; set; }
         
        //nav
        public ICollection<Order> Orders { get; set; }

    }
}