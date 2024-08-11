using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.DataAccessLayer.EntityFramework;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Gallery/")]
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;
        private readonly HotelContext _context;

        public GalleryController(IGalleryService galleryService, HotelContext context)
        {
            _galleryService = galleryService;
            _context = context;
        }

        [Route("")]
        [Route("GalleryList")]
        public IActionResult GalleryList()
        {
            var gallerylist = _galleryService.TGetListAll();
            return View(gallerylist);
        }

        [HttpGet]
        [Route("CreateGallery")]
        public IActionResult CreateGallery()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateGallery")]
        public IActionResult CreateGallery(Gallery model)
        {

            _context.Galleries.Add(model);
            _context.SaveChangesAsync();
            return RedirectToAction("GalleryList");

            return View(model);
        }

        [HttpGet]
        [Route("RemoveGallery/{id}")]
        public IActionResult RemoveGallery(int id)
        {
            
                _galleryService.TDelete(id);
                return RedirectToAction("GalleryList");
            
        }

        [HttpGet]
        [Route("UpdateGallery/{id}")]
        public IActionResult UpdateGallery(int id)
        {
            var room = _galleryService.TGetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        [HttpPost]
        [Route("UpdateGallery/{id}")]
        public IActionResult UpdateGallery(Gallery gallery )
        {
            _galleryService.TUpdate(gallery);
            return RedirectToAction("GalleryList");
        }

    }
}
