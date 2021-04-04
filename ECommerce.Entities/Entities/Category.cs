using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            BookCategories = new HashSet<BookCategory>();
            SubCategory = new HashSet<Category>();
            
        }
        public int ID { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Name { get; set; }


        //nav
        public virtual Category ParentCategory { get; set; }
        public virtual ICollection<Category> SubCategory { get; set; }
        public ICollection<BookCategory> BookCategories { get; set; }


    }
}
