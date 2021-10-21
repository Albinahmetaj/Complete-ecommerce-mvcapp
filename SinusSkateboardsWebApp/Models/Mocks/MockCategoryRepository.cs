using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Hoodie", Description=""},
                new Category{CategoryId=2, CategoryName="Cap", Description=""},
                new Category{CategoryId=3, CategoryName="Skateboard", Description=""},
                new Category{CategoryId=4, CategoryName="Tshirt", Description=""},
                new Category{CategoryId=5, CategoryName="Wheelrock", Description=""},
            };
    }
}
