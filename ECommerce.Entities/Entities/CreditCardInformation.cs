using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
   public class CreditCardInformation : IEntity
    { 
        public int ID { get; set; }
        public string CardHolderName { get; set; }
        public string CreditCardNumber { get; set; }
        public string ExpireMonth { get; set; }
        public string ExpireYear { get; set; }
        public string Cvv { get; set; }
        public int? CustomerID { get; set; }

        //Navigation
        public Customer Customer { get; set; }


    }
}
