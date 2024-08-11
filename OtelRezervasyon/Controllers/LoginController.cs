using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.EntityLayer.Concrete;
using OtelRezervasyon.Models;

namespace OtelRezervasyon.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel model)
        {
            if (model.Username != null && model.Password != null)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("AboutList", "About", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
                }
            }
            else
            {
                ModelState.AddModelError("", "Lütfen alanları boş geçmeyin!");
            }
            return View();
        }
    }
}
