using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECommerce.BLL.Concrete
{
    public class BookCategoryManager : IBookCategoryService
    {
        IBookCategoryDal _bookCategoryDal;

        public BookCategoryManager(IBookCategoryDal bookCategoryDal)
        {
            _bookCategoryDal = bookCategoryDal;
        }

        public IResults Add(BookCategory bookCategory)
        {
            _bookCategoryDal.Add(bookCategory);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(BookCategory bookCategory)
        {
            _bookCategoryDal.Delete(bookCategory);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<BookCategory> GetBookByBookId(int bookId)
        {
            return new SuccessDataResult<BookCategory>(_bookCategoryDal.Get(bc => bc.BookID == bookId));
        }

        public IDataResult<List<BookCategory>> GetList()
        {
            return new SuccessDataResult<List<BookCategory>>(_bookCategoryDal.GetList().ToList());
        }

        public IResults Update(BookCategory bookCategory)
        {
            _bookCategoryDal.Update(bookCategory);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
