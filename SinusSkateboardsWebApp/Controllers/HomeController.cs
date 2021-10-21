using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboardsWebApp.Models;
using SinusSkateboardsWebApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SinusSkateboardsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly AppDbContext  appDbContext;

        public HomeController(IProductRepository productRepository, AppDbContext  appDbContext)
        {
            _productRepository = productRepository;
            this.appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            
            var homeViewModel = new HomeViewModel
            {
                ProductsOfTheWeek = _productRepository.SaleOfTheWeek
            };

            return View(homeViewModel);
        }

        public async Task<IActionResult> Search(string searchstring)
        {
       

            var products = from p in appDbContext.Product.Include(x => x.ColorCategory).Include(x => x.Category)
                           select p;

            if (!String.IsNullOrEmpty(searchstring))
            {
                products = products.Where(s => s.Titel.Contains(searchstring) || s.ColorCategory.ColorName.Contains(searchstring) || s.Category.CategoryName.Contains(searchstring));
            }
            
            return View(await products.ToListAsync());
        }
    }
}
