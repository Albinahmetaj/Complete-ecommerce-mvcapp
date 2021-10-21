using SinusSkateboardsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.Components
{
    public class ColorMenu:ViewComponent
    {
        private readonly IColorCategoryRepository _colorRepository;
        public ColorMenu(IColorCategoryRepository colorRepository)
        {
            _colorRepository = colorRepository;
        }

        public IViewComponentResult Invoke()
        {
            var colors = _colorRepository.AllColors.OrderBy(c => c.ColorName);
            return View(colors);
        }
    }
}
