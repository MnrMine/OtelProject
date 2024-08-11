using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.EntityLayer.Concrete;
using System.Linq;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Dashboard/")]
    public class DashboardController : Controller
    {
        private readonly HotelContext _context;

        public DashboardController(HotelContext context)
        {
            _context = context;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            var totalRooms = _context.Roomses.Count();
            var occupiedRooms = _context.Roomses.Count(r => !r.Available);
            var availableRooms = totalRooms - occupiedRooms;

            var roomCapacities = _context.Roomses
                .Select(r => new { r.RoomsId, r.Capacity })
                .ToList();

            var pendingReservations = _context.Roomses
                .Where(r => r.ReservationStatus == "Pending")
                .Select(r => new { r.RoomsId, r.RoomName, r.Capacity })
                .ToList();

            var beds = _context.Roomses
                .Select(r => r.Bed)
                .ToList();

            var averageBeds = beds.Any() ? beds.Average() : 0;
            // Toplam Notification sayısı
            var totalNotifications = _context.Notifications.Count();

            ViewBag.TotalRooms = totalRooms;
            ViewBag.OccupiedRooms = occupiedRooms;
            ViewBag.AvailableRooms = availableRooms;
            ViewBag.RoomCapacities = roomCapacities;
            ViewBag.PendingReservations = pendingReservations;
            ViewBag.Beds = beds;
            ViewBag.AverageBeds = averageBeds;
            ViewBag.TotalNotifications = totalNotifications; // Toplam Notification sayısını ekle


            // Rezervasyon durumları için veri hazırlığı
            var reservationStatusData = _context.Roomses
                .GroupBy(r => r.ReservationStatus)
                .Select(g => new { Status = g.Key, Count = g.Count() })
                .ToList();

            ViewBag.ReservationStatusData = reservationStatusData;

            return View();
        }
    }
}
