using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SinusSkateboardsWebApp.Models;

namespace SinusSkateboardsWebApp.ViewModels
{
    public class ProductsListViewModel:EditImageViewModel
    {
        public IEnumerable<ProductModel> Products { get; set; }
        
        public string CurrentCategory { get; set; }
        public string CurrentColor { get; set; }
        public string Titel { get; set; }
       
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        public decimal Price { get; set; }
        
        
        public bool IsSaleOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ColorCategoryId { get; set; }
        public ColorCategory ColorCategory { get; set; }
        public string ImageCarouselOne { get; set; }
        public string ImageCarouselTwo { get; set; }
    }
}
