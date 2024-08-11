using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.EntityLayer.Concrete;
using OtelRezervasyon.Models;

namespace OtelRezervasyon.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegisterViewModel p)
        {
            if (p.Password != null)
            {
                AppUser appUser = new AppUser()
                {
                    Name = p.Name,
                    Email = p.Email,
                    Surname = p.Surname,
                    UserName = p.Username,
                    Description = "aa",
                    ImageUrl = "bb"
                };

                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Şifre alanı boş geçilemez");
                return View();
            }
        }
    }
}
