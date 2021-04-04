using ECommerce.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Entities.Entities
{
   public class Customer : IEntity
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            CreditCardInformations = new HashSet<CreditCardInformation>();
        } 
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        //Navigation
        public virtual Cart Cart { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<CreditCardInformation> CreditCardInformations { get; set; }
    }
}
