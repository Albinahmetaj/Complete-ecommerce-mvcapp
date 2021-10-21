using SinusSkateboardsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.ViewModels
{
    public class TestViewModel
    {
        public ProductModel Products { get; set; }
       
        public Category Categories { get; set; }
        public IEnumerable<ProductModel> Product { get; set; }
        public IEnumerable<ColorCategory> Colors { get; set; }
    }
}
