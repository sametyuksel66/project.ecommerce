using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
    public class Translator : IEntity
    {
        public Translator()
        {
            BookTranslators = new HashSet<BookTranslator>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EMail { get; set; }
        public string About { get; set; }

        //nav 
        public ICollection<BookTranslator> BookTranslators { get; set; }
    }
}
