using ECommerce.Core.DataAccess.BaseClasses.EntityFramework;
using ECommerce.DAL.Abstract;
using ECommerce.DAL.Concrete.EntityFramework.Contexts;
using ECommerce.DTO.Concrete;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.DAL.Concrete
{
    public class EfCategoryDal : EFRepositoryBase<Category, ECommerceDBContext, int>, ICategoryDal
    {

        public List<GetCategoryDTO> GetCategoryDetails(Expression<Func<Category, bool>> filter = null)
        {
            using (ECommerceDBContext context = new ECommerceDBContext())
            {
                var result = (from c in filter == null ? context.Categories : context.Categories.Where(filter)
                              select new GetCategoryDTO
                              {
                                  ID = c.ID,
                                  Name = c.Name,
                                  ParentCategoryName = c.ParentCategory.Name
                              });

                return result.ToList();
            }
        }

        public List<GetCategoryDTO> GetSubCategory(Expression<Func<Category, bool>> filter = null)
        {
            using (ECommerceDBContext context = new ECommerceDBContext())
            {
                var result = from c in filter == null ?
                             context.Categories :
                             context.Categories.Where(filter) select new GetCategoryDTO
                             {
                                 ID = c.ID,
                                 Name = c.Name
                             };
                return result.ToList();
            }

        }
    }
}
