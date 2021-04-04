using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    interface IAddressService
    {

        IResults Add(Address address);

        IResults Delete(Address address);
        IResults Update(Address address);

        IDataResult<List<Address>> GetList();

        IDataResult<Address> GetAddressByUserId(int userId);

    }
}
