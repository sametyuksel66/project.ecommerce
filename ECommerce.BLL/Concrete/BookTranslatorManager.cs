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
    public class BookTranslatorManager : IBookTranslatorService
    {
        IBookTranslatorDal _bookTranslatorDal;

        public BookTranslatorManager(IBookTranslatorDal bookTranslatorDal)
        {
            _bookTranslatorDal = bookTranslatorDal;
        }

        public IResults Add(BookTranslator bookTranslator)
        {
            _bookTranslatorDal.Add(bookTranslator);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(BookTranslator bookTranslator)
        {
            _bookTranslatorDal.Delete(bookTranslator);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<List<BookTranslator>> GetList()
        {
            return new SuccessDataResult<List<BookTranslator>>(_bookTranslatorDal.GetList().ToList());
        }

        public IDataResult<BookTranslator> GetTranslatorByBookId(int bookTranslatorId)
        {
            return new SuccessDataResult<BookTranslator>(_bookTranslatorDal.Get(bt => bt.TranslatorID == bookTranslatorId));
        }

        public IResults Update(BookTranslator bookTranslator)
        {
            _bookTranslatorDal.Update(bookTranslator);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
