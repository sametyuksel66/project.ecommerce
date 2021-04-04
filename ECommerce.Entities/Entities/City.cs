using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Entities.Entities
{
    public class City : IEntity
    {
        public City()
        {
            Districts = new HashSet<District>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int? CountryID { get; set; }
         
        //nav
        public Country Country { get; set; }
        public ICollection<District> Districts { get; set; }

    }
}
