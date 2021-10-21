using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class ColorCategory
    {

        [Key]
        public int ColorCategoryId { get; set; }
        [Display(Name = "Color")]
        public string ColorName { get; set; }
        public string ColorDescription { get; set; }
        public List<ProductModel> Product { get; set; }
    }
}
