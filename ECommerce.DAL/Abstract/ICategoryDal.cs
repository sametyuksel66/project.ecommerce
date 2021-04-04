using ECommerce.Core.DataAccess.Abstract;
using ECommerce.DTO.Concrete;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ECommerce.DAL.Abstract
{
    public interface ICategoryDal: IEntityRepository<Category, int>
    {
        List<GetCategoryDTO> GetCategoryDetails(Expression<Func<Category, bool>> filter = null);

        List<GetCategoryDTO> GetSubCategory(Expression<Func<Category, bool>> filter);
        
    }
}
