using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.DTOs
{
    public class addCategoryDTO
    {
        public List<GetCategoryDTO> categoryLists { get; set; }
        public string ParentCategoryId { get; set; }
        public string name { get; set; }
        


    }
}
