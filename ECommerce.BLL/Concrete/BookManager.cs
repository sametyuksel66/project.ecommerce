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
    class BookManager : IBookService
    {
        private IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }


        public IResults Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Book book)
        {
            _bookDal.Delete(book);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Book> GetBookByBookId(int BookId)
        {
            return new SuccessDataResult<Book>(_bookDal.Get(c => c.ID == BookId));
        }

        public IDataResult<List<Book>> GetList()
        {
            return new SuccessDataResult<List<Book>>(_bookDal.GetList().ToList());
        }

        public IResults Update(Book book)
        {
            _bookDal.Update(book);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
