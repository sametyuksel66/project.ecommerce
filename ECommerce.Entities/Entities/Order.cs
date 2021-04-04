using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Order:IEntity
    { 
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsGiftPackage { get; set; }
        public string ShippingTrackingNumber { get; set; }
        public string GiftNote { get; set; }
        public string PaymentType { get; set; }
        public string OrderStatus { get; set; }
        public int? CartID { get; set; }
        public int? ShipperID { get; set; }

        //nav
        public Cart Cart { get; set; }
        public Shipper Shipper { get; set; }
    }
}
