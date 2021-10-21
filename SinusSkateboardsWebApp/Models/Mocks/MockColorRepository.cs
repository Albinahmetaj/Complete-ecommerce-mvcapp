using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class MockColorRepository:IColorCategoryRepository
    {
        public IEnumerable<ColorCategory> AllColors =>
           new List<ColorCategory>
           {
                new ColorCategory{ColorCategoryId=1, ColorName="White", ColorDescription=""},
                new ColorCategory{ColorCategoryId=2, ColorName="Silver", ColorDescription=""},
                new ColorCategory{ColorCategoryId=3, ColorName="Gray", ColorDescription=""},
                new ColorCategory{ColorCategoryId=4, ColorName="Black", ColorDescription=""},
                new ColorCategory{ColorCategoryId=5, ColorName="Red", ColorDescription=""},
                new ColorCategory{ColorCategoryId=6, ColorName="Maroon", ColorDescription=""},
                new ColorCategory{ColorCategoryId=7, ColorName="Yellow", ColorDescription=""},
                new ColorCategory{ColorCategoryId=8, ColorName="Olive", ColorDescription=""},
                new ColorCategory{ColorCategoryId=9, ColorName="Lime", ColorDescription=""},
                new ColorCategory{ColorCategoryId=10, ColorName="Green", ColorDescription=""},
                new ColorCategory{ColorCategoryId=11, ColorName="Aqua", ColorDescription=""},
                new ColorCategory{ColorCategoryId=12, ColorName="Teal", ColorDescription=""},
                new ColorCategory{ColorCategoryId=13, ColorName="Blue", ColorDescription=""},
                new ColorCategory{ColorCategoryId=14, ColorName="Navy", ColorDescription=""},
                new ColorCategory{ColorCategoryId=15, ColorName="Fuschia", ColorDescription=""},
                new ColorCategory{ColorCategoryId=16, ColorName="Purple", ColorDescription=""},
                 new ColorCategory{ColorCategoryId=17, ColorName="Other", ColorDescription=""},
           };
    }
}

