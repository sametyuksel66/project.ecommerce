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
    public class TranslatorManager : ITranslatorService
    {
        ITranslatorDal _translatorDal;

        public TranslatorManager(ITranslatorDal translatorDal)
        {
            _translatorDal = translatorDal;
        }

        public IResults Add(Translator translator)
        {
            _translatorDal.Add(translator);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Translator translator)
        {
            _translatorDal.Delete(translator);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<List<Translator>> GetList()
        {
            return new SuccessDataResult<List<Translator>>(_translatorDal.GetList().ToList());
        }

        public IDataResult<Translator> GetTranslatorById(int id)
        {
            return new SuccessDataResult<Translator>(_translatorDal.Get(x => x.ID == id));
        }

        public IResults Update(Translator translator)
        {
            _translatorDal.Update(translator);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
