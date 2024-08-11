using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Controllers
{
    public class OurRoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
