using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Context;

namespace OtelRezervasyon.Areas.Admin.ViewComponents
{
    public class _AdminLayoutNotificationComponentPartial : ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly HotelContext _context;
        public _AdminLayoutNotificationComponentPartial(INotificationService notificationService, HotelContext context)
        {
            _notificationService = notificationService;
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.bsayi = _context.Notifications.Count();
            var values = _notificationService.TGetListNotification();
            return View(values);
        }
    }
}
