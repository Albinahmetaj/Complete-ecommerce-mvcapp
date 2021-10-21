using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Models
{
    public interface IColorCategoryRepository
    {
        IEnumerable<ColorCategory> AllColors { get; }
    }
}
