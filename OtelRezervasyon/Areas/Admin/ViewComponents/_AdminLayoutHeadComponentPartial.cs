using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
	public class _AdminLayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
