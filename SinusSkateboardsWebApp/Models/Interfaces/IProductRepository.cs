using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> AllProducts { get; }
        IEnumerable<ProductModel> SaleOfTheWeek { get; }
        
        ProductModel GetProductById(int productId);
    }
}
