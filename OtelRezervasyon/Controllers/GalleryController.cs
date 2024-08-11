using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
