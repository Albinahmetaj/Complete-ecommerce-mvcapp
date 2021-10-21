using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboardsWebApp.Models;

namespace SinusSkateboardsWebApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<ProductModel> ProductsOfTheWeek { get; set; }
    }
}
