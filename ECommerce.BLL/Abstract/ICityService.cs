using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ICityService
    {
        IResults Add(City city);

        IResults Delete(City city);
        IResults Update(City city);

        IDataResult<List<City>> GetList();

        IDataResult<City> GetCityByID(int cityId);
    }
}
