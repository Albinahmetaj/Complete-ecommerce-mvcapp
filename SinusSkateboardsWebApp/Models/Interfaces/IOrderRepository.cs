using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        Task<List<Order>> GetOrdersByUserIdAsync(int orderId);
    }
}
