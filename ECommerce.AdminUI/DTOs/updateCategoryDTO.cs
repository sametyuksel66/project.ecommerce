using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.AdminUI.DTOs
{
    public class updateCategoryDTO
    {
        public List<GetCategoryDTO> categoryLists { get; set; }
        public int? ParentCategoryId { get; set; }
        public string name { get; set; }
        public int id { get; set; }

    }
    public class convertUpdateCategoryDTO
    {
        public updateCategoryDTO data { get; set; }

    }

}
