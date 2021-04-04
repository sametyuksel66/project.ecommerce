using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
  public class Image : IEntity
    {
        public int ID { get; set; }
        //public string URL { get; set; }
        public string Name { get; set; }
        public byte[] Road { get; set; }
        public int? BookID { get; set; }


        //Nav
        public Book Book { get; set; }

    }
}
