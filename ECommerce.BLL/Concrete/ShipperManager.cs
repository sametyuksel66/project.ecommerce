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
    public class ShipperManager : IShipperService
    {
        IShipperDal _shipperDal;

        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        public IResults Add(Shipper shipper)
        {
            _shipperDal.Add(shipper);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Shipper shipper)
        {
            _shipperDal.Delete(shipper);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Shipper> GetShipperById(int shipperId)
        {
            return new SuccessDataResult<Shipper>(_shipperDal.Get(s => s.ID == shipperId));
        }

        public IDataResult<List<Shipper>> GetList()
        {
            return new SuccessDataResult<List<Shipper>>(_shipperDal.GetList().ToList());
        }

        public IResults Update(Shipper shipper)
        {
            _shipperDal.Update(shipper);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
