//using ECommerce.Core.Dtos;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ECommerce.DTO.Concrete
{
    public class GetCategoryDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ParentCategoryName { get; set; }


    }
}
