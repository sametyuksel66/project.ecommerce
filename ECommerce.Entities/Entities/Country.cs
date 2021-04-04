using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Country:IEntity
    {
        public Country()
        {
            Cities = new HashSet<City>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
         
        //nav
        public ICollection<City> Cities { get; set; }
    }
}
