using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
   public class BookAuthor : IEntity
    {
        public int BookID { get; set; }
        public int AuthorID { get; set; }

        //nav 
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
