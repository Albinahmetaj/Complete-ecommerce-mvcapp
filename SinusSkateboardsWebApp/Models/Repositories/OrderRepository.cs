using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext  _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext  appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            order.Ordernumber = Guid.NewGuid().ToString();
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price,
                    Titel = shoppingCartItem.Product.Titel
                };

                order.OrderDetails.Add(orderDetail);
            }

            _appDbContext.Orders.Add(order);

            _appDbContext.SaveChanges();
        }

        public async Task<List<Order>> GetOrdersByUserIdAsync(int orderId)
        {
            var orders = await _appDbContext.Orders.Include(n => n.OrderDetails).ThenInclude(n => n.Product).Where(n => n.OrderId == orderId).ToListAsync();
            return orders;
        }
    }
}
