using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Data
{
    public interface IOrderDetailsData
    {
        OrderDetail EditOrderDetail(OrderDetail orderDetail);
    }
}
