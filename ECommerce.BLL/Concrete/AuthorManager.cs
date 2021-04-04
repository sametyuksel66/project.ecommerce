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
    public class AuthorManager : IAuthorService
    {

        IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }

        public IResults Add(Author author)
        {
            _authorDal.Add(author);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Author author)
        {

            _authorDal.Delete(author);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Author> GetAuthorByID(int authorId)
        {
            return new SuccessDataResult<Author>(_authorDal.Get(a => a.ID == authorId));
        }

        public IDataResult<List<Author>> GetList()
        {
            return new SuccessDataResult<List<Author>>(_authorDal.GetList().ToList());
        }

        public IResults Update(Author author)
        {
            _authorDal.Update(author);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
