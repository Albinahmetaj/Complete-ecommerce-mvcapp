using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboardsWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SinusSkateboardsWebApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly AppDbContext  _context;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart, AppDbContext  context)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sinusskateboardContext = _context.Orders.Include(o => o.OrderDetails).ThenInclude(p => p.Product);
            return View(await sinusskateboardContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = await _context.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(o => o.Product).ThenInclude(o => o.ColorCategory)
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }
        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some products first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                
                return RedirectToAction("CheckoutComplete", order);
                
            }
            return View(order);
        }

        public async Task<IActionResult> CheckoutComplete(int orderId)
        {
            

            var orders = await _orderRepository.GetOrdersByUserIdAsync(orderId);
            ViewBag.CheckoutCompleteMessage = "Thanks for your order!";
            
            return View(orders);
        }
    }
}
