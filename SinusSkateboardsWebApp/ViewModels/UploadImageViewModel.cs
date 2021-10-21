using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SinusSkateboardsWebApp.ViewModels
{
    public class UploadImageViewModel
    {
        [Display(Name = "Image")]
        public IFormFile ProductPicture { get; set; }
    }
}
