using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface ICountryService
    {
        IResults Add(Country country);

        IResults Delete(Country country);
        IResults Update(Country country);

        IDataResult<List<Country>> GetList();

        IDataResult<Country> GetCountryById(int countryId);
    }
}
