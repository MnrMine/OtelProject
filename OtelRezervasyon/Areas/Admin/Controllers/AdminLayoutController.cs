using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class AdminLayoutController : Controller
	{
		public IActionResult _AdminLayout()
		{
			return View();
		}
	}
}
