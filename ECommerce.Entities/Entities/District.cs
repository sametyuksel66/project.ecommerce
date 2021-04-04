using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class District : IEntity
    {
        public District()
        {
            Addresses = new HashSet<Address>();
        }
         
        public int ID { get; set; }
        public string Name { get; set; }
        public int? CityID { get; set; }

        //nav
        public City City { get; set; }
        public ICollection<Address> Addresses { get; set; }

    }
}
