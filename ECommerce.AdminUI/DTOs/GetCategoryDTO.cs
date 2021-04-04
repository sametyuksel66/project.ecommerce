using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.DTOs
{
    public class GetCategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ParentCategoryName { get; set; }
    }
}
