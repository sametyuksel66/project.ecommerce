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
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }



        public IResults Add(Order order)
        {
            _orderDal.Add(order);
            return new SuccessResult(Message.ProductAdded);
        }

        public IResults Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Message.ProductAdded);
        }

        public IDataResult<List<Order>> GetList()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetList().ToList());
        }

        public IDataResult<Order> GetOrderById(int orderId)
        {
            return new SuccessDataResult<Order>(_orderDal.Get(o => o.ID == orderId));
        }

        public IResults Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Message.ProductAdded);
        }
    }
}
