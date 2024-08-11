using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;

namespace OtelRezervasyon.UIViewComponents.UILayoutViewComponents
{
    public class _GalleryUILayoutComponentPartial : ViewComponent
    {
        private readonly IGalleryService _galleryService;
public _GalleryUILayoutComponentPartial(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public IViewComponentResult Invoke()
        {
            var gallery = _galleryService.TGetListAll();
            return View(gallery);
        }
    }
}
