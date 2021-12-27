using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public class SqlOrderDetails : IOrderDetailsData
    {
        private readonly FarmpeContext farmpeContext;
        public SqlOrderDetails(FarmpeContext farmpeContext)
        {
            this.farmpeContext = farmpeContext;
        }
        public OrderDetail EditOrderDetail(OrderDetail orderDetail)
        {
            var existingOrder = farmpeContext.OrderDetails.Find(orderDetail.OrderId);
            if(existingOrder != null)
            {
                existingOrder.OrderId = orderDetail.OrderId;
                existingOrder.ProductId = orderDetail.ProductId;
                existingOrder.Quantity = orderDetail.Quantity;
            }
            return existingOrder;
        }
    }
}
