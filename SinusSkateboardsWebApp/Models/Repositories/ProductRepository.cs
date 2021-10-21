using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SinusSkateboardsWebApp.Models
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext  _appDbContext;

        public ProductRepository(AppDbContext  appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<ProductModel> AllProducts
        {
            get
            {
                return _appDbContext.Product.Include(c => c.Category).Include(x => x.ColorCategory);
            }
        }

        public IEnumerable<ProductModel> SaleOfTheWeek
        {
            get
            {
                return _appDbContext.Product.Include(c => c.Category).Where(p => p.IsSaleOfTheWeek);
            }
        }


        public ProductModel GetProductById(int productId)
        {
            return _appDbContext.Product.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
