
using Core.Utilities.Results;
using ECommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.BLL.Abstract
{
    public interface IOrderService
    {
        IDataResult<Order> GetOrderById(int orderId);
        IDataResult<List<Order>> GetList();
        IResults Add(Order order);
        IResults Delete(Order order);
        IResults Update(Order order);
    }
}
