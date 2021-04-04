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
    public class AuthorBookManager : IAuthorBookService
    {
        IBookAuthorDal _bookAuthorDal;

        public AuthorBookManager(IBookAuthorDal bookAuthorDal)
        {
            _bookAuthorDal = bookAuthorDal;
        }

        public IResults Add(BookAuthor bookAuthor)
        {
            _bookAuthorDal.Add(bookAuthor);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(BookAuthor bookAuthor)
        {
            _bookAuthorDal.Delete(bookAuthor);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<BookAuthor> GetBookByAuthorId(int authorId)
        {
            return new SuccessDataResult<BookAuthor>(_bookAuthorDal.Get(b => b.AuthorID == authorId));
        }

        public IDataResult<List<BookAuthor>> GetList()
        {
            return new SuccessDataResult<List<BookAuthor>>(_bookAuthorDal.GetList().ToList());
        }

        public IResults Update(BookAuthor bookAuthor)
        {
            _bookAuthorDal.Update(bookAuthor);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
