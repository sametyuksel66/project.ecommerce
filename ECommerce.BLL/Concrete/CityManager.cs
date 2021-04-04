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
    public class CityManager : ICityService
    {

        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResults Add(City city)
        {
            _cityDal.Add(city);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(City city)
        {
            _cityDal.Delete(city);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<City> GetCityByID(int cityId)
        {
            return new SuccessDataResult<City>(_cityDal.Get(x => x.ID == cityId));

        }

        public IDataResult<List<City>> GetList()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetList().ToList());
        }

        public IResults Update(City city)
        {
            _cityDal.Update(city);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
