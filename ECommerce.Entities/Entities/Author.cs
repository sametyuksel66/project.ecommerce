using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Author : IEntity
    {
        public Author() 
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }

        //nav
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
