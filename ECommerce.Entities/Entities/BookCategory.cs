using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class BookCategory : IEntity
    {
        public int CategoryID { get; set; }
        public int BookID { get; set; }

        //nav 
        public Book Book { get; set; }
        public Category Category { get; set; }
    }
    
}
