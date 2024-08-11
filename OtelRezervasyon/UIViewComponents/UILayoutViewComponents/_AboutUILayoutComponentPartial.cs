using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;

namespace OtelRezervasyon.UIViewComponents.UILayoutViewComponents
{
    public class _AboutUILayoutComponentPartial : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutUILayoutComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetListAll();
            return View(values);
        }
    }
}
