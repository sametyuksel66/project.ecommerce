
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IShipperService
    {
        IResults Add(Shipper shipper);

        IResults Delete(Shipper shipper);
        IResults Update(Shipper shipper);

        IDataResult<List<Shipper>> GetList();

        IDataResult<Shipper> GetShipperById(int shipperId);

    }
    
}
  