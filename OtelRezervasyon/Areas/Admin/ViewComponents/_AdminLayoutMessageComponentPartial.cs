using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
    public class _AdminLayoutMessageComponentPartial : ViewComponent
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly IContactService _contactService;

        public _AdminLayoutMessageComponentPartial(UserManager<AppUser> userManager, IContactService contactService)
        {
            _userManager = userManager;
            _contactService = contactService;
        }
        public async Task<IViewComponentResult> InvokeAsync(string p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var messagelist = _contactService.TGetMessageListByAdmin(p);
            ViewBag.mesajsayisi = _contactService.TGetMessageListByAdmin(p).Count();
            return View(messagelist);
        }
    }
}
