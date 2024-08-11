using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/About/")]
    public class AboutController : Controller
    {
        //private readonly IAboutService _aboutService;
        //private readonly UserManager<AppUser> _userManager;

        //public AboutController(IAboutService aboutService, UserManager<AppUser> userManager)
        //{
        //    _aboutService = aboutService;
        //    _userManager = userManager;
        //}

        //[Route("")]
        //[Route("AboutList")]
        //public IActionResult AboutList()
        //{
        //    var values = _aboutService.TGetListAll();
        //    return View(values);
        //}
        private readonly IAboutService _aboutService;
        private readonly HotelContext _context;

        public AboutController(IAboutService aboutService, HotelContext context)
        {
            _aboutService =aboutService;
            _context = context;
        }

        //[Route("")]
        [Route("AboutList")]
        public IActionResult AboutList()
        {
            var aboutlist = _aboutService.TGetListAll();
            return View(aboutlist);
        }

        [HttpGet]
        [Route("CreateAbout")]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateAbout")]
        public IActionResult CreateAbout(About model)
        {

            _context.Abouts.Add(model);
            _context.SaveChangesAsync();
            return RedirectToAction("AboutList");

            
        }

        [HttpGet]
        [Route("RemoveAbout/{id}")]
        public IActionResult RemoveAbout(int id)
        {

            _aboutService.TDelete(id);
            return RedirectToAction("AboutList");

        }

        [HttpGet]
        [Route("UpdateAbout/{id}")]
        public IActionResult UpdateAbout(int id)
        {
            var about = _aboutService.TGetById(id);
           
            return View(about);
        }

        [HttpPost]
        [Route("UpdateAbout/{id}")]
        public IActionResult UpdateAbout(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("AboutList");
        }
    }
}
