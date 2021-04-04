using Core.Utilities.Results;
using ECommerce.DTO.Concrete;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Abstract
{
    public interface ICategoryService
    {
        IResults Add(Category category);

        IResults Delete(Category category);
        IResults Update(Category category);

        IDataResult<List<Category>> GetList();
       

        IDataResult<Category> GetCategoryById(int categoryID);

        IDataResult<List<GetCategoryDTO>> CategoryDetails(Expression<Func<Category, bool>> filter = null);

        IDataResult<List<GetCategoryDTO>> GetSubCategory(Expression<Func<Category, bool>> filter);

        
    }
}
