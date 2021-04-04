using Business.Constants;
using Core.Utilities.Results;
using ECommerce.BLL.Abstract;
using ECommerce.DAL.Abstract;
using ECommerce.Entities.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.BLL.Concrete
{
    public class CountryManager : ICountryService
    {

        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResults Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Country country)
        {
            _countryDal.Delete(country);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Country> GetCountryById(int countryId)
        {
            return new SuccessDataResult<Country>(_countryDal.Get(x => x.ID == countryId));
        }

        public IDataResult<List<Country>> GetList()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetList().ToList());
        }

        public IResults Update(Country country)
        {
            _countryDal.Update(country);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
