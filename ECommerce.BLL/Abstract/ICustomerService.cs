using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    interface ICustomerService
    {

        IResults Add(Customer customer);

        IResults Delete(Customer customer);
        IResults Update(Customer customer);

        IDataResult<List<Customer>> GetList();

        IDataResult<Customer> GetCustomerByUserId(int userId);
    }
}
