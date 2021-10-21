using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SinusSkateboardsWebApp.Areas.Identity.Pages.Admin
{
    [BindProperties]
    public class LoginAdminModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;

        [Required(ErrorMessage = "Username is missing")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is missing")]
        public string Password { get; set; }

        public LoginAdminModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                // Sign in user
                var result = await signInManager.PasswordSignInAsync(Username, Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToPage("/Index");
                }
            }

            return Page();
        }
    }
}
