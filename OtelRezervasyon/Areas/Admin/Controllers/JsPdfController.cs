using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/JsPdf/")]
    public class JsPdfController : Controller
    {
        [Route("")]
        [Route("PdfExport")]
        public IActionResult PdfExport()
        {
            return View();
        }
    }
}
