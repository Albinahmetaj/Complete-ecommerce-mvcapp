using SinusSkateboardsWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name = "Title")]
        public string Titel { get; set; }
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Display(Name = "Description")]
        public string LongDescription { get; set; }
        
        public decimal Price { get; set; }
        public string Photopath { get; set; }
        [Display(Name = "Sales of the week")]
        public bool IsSaleOfTheWeek { get; set; }
        [Display(Name = "In stock")]
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ColorCategoryId { get; set; }
        
        public ColorCategory ColorCategory { get; set; }
        
        
        public string ImageCarouselOne { get; set; }
        public string ImageCarouselTwo { get; set; }
        



    }
}
