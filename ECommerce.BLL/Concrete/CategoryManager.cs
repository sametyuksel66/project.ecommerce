using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.DTO.Concrete;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ECommerce.BLL.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResults Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Message.ProductAdded);
        }

        public IDataResult<List<GetCategoryDTO>> CategoryDetails(Expression<Func<Category, bool>> filter = null)
        {
            return new SuccessDataResult<List<GetCategoryDTO>>(_categoryDal.GetCategoryDetails(filter));
        }

        public IResults Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Message.ProductDeleted);
        }

       
        public IDataResult<Category> GetCategoryById(int categoryID)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(x => x.ID == categoryID));
        }

     

        public IDataResult<List<Category>> GetSubCategory(Expression<Func<Category, bool>> filter)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList(filter, a=>a.SubCategory).ToList());
        }
             

        public IResults Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Message.ProdctUpdated);
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList(x => x.ParentCategoryId == null,a=>a.SubCategory,a=>a.ParentCategory).ToList());            
        }


        IDataResult<List<GetCategoryDTO>> ICategoryService.GetSubCategory(Expression<Func<Category, bool>> filter)
        {
            return new SuccessDataResult<List<GetCategoryDTO>>();
        }
    }
}
