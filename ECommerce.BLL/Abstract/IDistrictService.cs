using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IDistrictService
    {
        IResults Add(District district);

        IResults Delete(District district);
        IResults Update(District district);

        IDataResult<List<District>> GetList();

        IDataResult<District> GetDistrictById(int districtId);
    }
}
