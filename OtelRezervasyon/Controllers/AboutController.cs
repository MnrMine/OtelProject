using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
