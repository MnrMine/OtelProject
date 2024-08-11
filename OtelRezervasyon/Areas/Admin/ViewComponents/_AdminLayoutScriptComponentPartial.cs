using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
	public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
