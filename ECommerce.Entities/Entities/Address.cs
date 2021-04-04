using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Address : IEntity
    {
         
        public int ID { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string RecipientPhone { get; set; }
        public int? DistrictID { get; set; }
        public int? CustomerID { get; set; }

        //nav
        public District District { get; set; }
        public Customer Customer { get; set; }



        

    }
}
