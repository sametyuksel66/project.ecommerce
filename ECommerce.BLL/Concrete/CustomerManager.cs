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
    class CustomerManager : ICustomerService
    {
       private ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customer)
        {
            _customerDal = customer;
        }

        public IResults Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Message.ProductDeleted);
        }

        public IDataResult<Customer> GetCustomerByUserId(int userId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.ID == userId));
        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
        }

        public IResults Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Message.ProdctUpdated);
        }
    }
}
