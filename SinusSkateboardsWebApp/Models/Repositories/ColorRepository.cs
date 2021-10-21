using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public class ColorRepository: IColorCategoryRepository
    {
        private readonly AppDbContext  _context;

        public ColorRepository(AppDbContext  context)
        {
            _context = context;
        }

        public IEnumerable<ColorCategory> AllColors => _context.ColorCategories;
    }
}
