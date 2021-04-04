using ECommerce.Core.Entities;

namespace ECommerce.Entities.Entities
{
    public class CartItem : IEntity
    {
        public int CartID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }

        //nav
        public Book Book { get; set; }
        public Cart Cart { get; set; }
    }
} 