using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
   public class BookTranslator : IEntity
    {
        public int TranslatorID { get; set; }
        public int BookID { get; set; }

        //nav 
        public Book Book { get; set; }
        public Translator Translator { get; set; }
    }
}
