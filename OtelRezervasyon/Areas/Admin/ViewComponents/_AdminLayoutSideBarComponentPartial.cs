using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
    public class _AdminLayoutSideBarComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutSideBarComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.resim = values.ImageUrl;
            ViewBag.adsoyad = values.Name + "" + values.Surname;
            return View();
        }
    }
}
