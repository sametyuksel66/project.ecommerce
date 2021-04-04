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
    class AddressManager : IAddressService
    {
        private IAddressDal _addressDal;
        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }
        public IResults Add(Address address)
        {
            _addressDal.Add(address);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Address address)
        {
            _addressDal.Delete(address);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Address> GetAddressByUserId(int userId)
        {
            return new SuccessDataResult<Address>(_addressDal.Get(c => c.ID == userId));
        }

        public IDataResult<List<Address>> GetList()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetList().ToList());
        }

        public IResults Update(Address address)
        {
            _addressDal.Update(address);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
