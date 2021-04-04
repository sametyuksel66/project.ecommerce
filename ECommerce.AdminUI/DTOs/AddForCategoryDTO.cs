using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.DTOs
{
    public class AddForCategoryDTO
    {
        public int ParentCategoryId { get; set; }
        public string Name { get; set; }
    }
}
