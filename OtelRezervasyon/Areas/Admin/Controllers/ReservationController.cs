using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.EntityLayer.Concrete;
using System.Linq;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Reservation/")]
    public class ReservationController : Controller
    {
        private readonly HotelContext _context;

        public ReservationController(HotelContext context)
        {
            _context = context;
        }
        /**/

        [HttpPost]
        [Route("RequestReservation")]
        public IActionResult RequestReservation([FromBody] RequestReservationModel request)
        {
            var room = _context.Roomses.Find(request.RoomId);
            if (room != null && room.ReservationStatus == "None")
            {
                room.ReservationStatus = "Pending";
                _context.SaveChanges();
            }
            return Json(new { message = "Rezervasyon talebiniz alındı" });
        }

        [HttpPost]
        [Route("ApproveReservation")]
        public IActionResult ApproveReservation([FromBody] int roomId)
        {
            var room = _context.Roomses.Find(roomId);
            if (room != null && room.Available && room.ReservationStatus == "Pending")
            {
                room.Available = false;
                room.ReservationStatus = "Approved";
                _context.SaveChanges();
            }
            return Json(new { success = true });
        }

        [HttpPost]
        [Route("RejectReservation")]
        public IActionResult RejectReservation([FromBody] int roomId)
        {
            var room = _context.Roomses.Find(roomId);
            if (room != null && room.ReservationStatus == "Pending")
            {
                room.ReservationStatus = "Rejected";
                _context.SaveChanges();
            }
            return Json(new { success = true });
        }
        [Route("")]
        [Route("AdminView")]
        public IActionResult AdminView()
        {
            var rooms = _context.Roomses.ToList();
            return View(rooms);
        }
    }

    public class RequestReservationModel
    {
        public int RoomId { get; set; }
    }
}