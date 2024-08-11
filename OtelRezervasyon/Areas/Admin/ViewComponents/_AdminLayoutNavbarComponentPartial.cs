using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
	public class _AdminLayoutNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
