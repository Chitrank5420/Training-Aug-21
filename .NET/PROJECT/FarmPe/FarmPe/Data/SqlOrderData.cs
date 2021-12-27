using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public class SqlOrderData : IOrderData
    {
        private readonly FarmpeContext _farmpeContext;

        public SqlOrderData(FarmpeContext farmpeContext)
        {
            _farmpeContext = farmpeContext;
        }
        public Order EditOrder(Order order)
        {
            var myOrder = _farmpeContext.Orders.Find(order.OrderId);
            if (order != null)
            {
                myOrder.OrderId = order.OrderId;
                myOrder.OrderDate = order.OrderDate;
                myOrder.UserId = order.UserId;
                myOrder.Amount = order.Amount;
                myOrder.PaymentType = order.PaymentType;
                _farmpeContext.Orders.Update(myOrder);
                _farmpeContext.SaveChanges();
            }
            return myOrder;
        }
    }
}
