using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Language : IEntity
    {
        public Language()
        {
            Books = new HashSet<Book>();
        }
             

        public int ID { get; set; }
        public string Name { get; set; }

        //nav
        public ICollection<Book> Books { get; set; }
    }
}
