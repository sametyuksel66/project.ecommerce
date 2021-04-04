using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Campaign : IEntity
    {
        public Campaign()
        {
            Carts = new HashSet<Cart>();
        }
        public int ID { get; set; }
        public string CampaignCode { get; set; }

        //nav 
        public ICollection<Cart> Carts { get; set; }

    }
}
