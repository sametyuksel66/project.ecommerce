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
    public class LanguageManager : ILanguageService
    {
        ILanguageDal _languageDal;

        public LanguageManager(ILanguageDal languageDal)
        {
            _languageDal = languageDal;
        }

        public IResults Add(Language language)
        {
            _languageDal.Add(language);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Language language)
        {
            _languageDal.Delete(language);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Language> GetLanguageById(int id)
        {
            return new SuccessDataResult<Language>(_languageDal.Get(x => x.ID == id));
        }

        public IDataResult<List<Language>> GetList()
        {
            return new SuccessDataResult<List<Language>>(_languageDal.GetList().ToList());
        }

        public IResults Update(Language language)
        {
            _languageDal.Update(language);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
