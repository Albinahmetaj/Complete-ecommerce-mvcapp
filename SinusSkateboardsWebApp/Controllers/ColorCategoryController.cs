using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SinusSkateboardsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Controllers
{
    public class ColorCategoryController : Controller
    {
        private readonly AppDbContext  context;

        public ColorCategoryController(AppDbContext  context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            if(category == null)
            {
                return View("Not Found");
            }

            return View(category);
        }
    }
}
