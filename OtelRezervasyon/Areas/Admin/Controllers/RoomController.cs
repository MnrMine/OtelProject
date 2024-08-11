using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Room/")]
    public class RoomController : Controller
    {
        private readonly HotelContext _context;
        private readonly IRoomService _roomService;

        public RoomController(HotelContext context, IRoomService roomService)
        {
            _context = context;
            _roomService = roomService;
        }

        [Route("")]
        [Route("RoomList")]
        public IActionResult RoomList()
        {
            var rooms = _roomService.TGetListAll();
            return View(rooms);
        }

        [HttpGet]
        [Route("CreateRoom")]
        public IActionResult CreateRoom()
        {
            return View();
        }

        [HttpPost]
        [Route("CreateRoom")]
        public IActionResult CreateRoom(Rooms model)
        {
           
                _context.Roomses.Add(model);
                _context.SaveChangesAsync();
                return RedirectToAction("RoomList");
            
            return View(model);
        }

        [HttpGet]
        [Route("RemoveRoom/{id}")]
        public IActionResult RemoveRoom(int id)
        {
            var room = _roomService.TGetById(id);
            if (room != null)
            {
                _roomService.TDelete(id);
            }
            return RedirectToAction("RoomList");
        }

        [HttpGet]
        [Route("UpdateRoom/{id}")]
        public IActionResult UpdateRoom(int id)
        {
            var room = _roomService.TGetById(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        [HttpPost]
        [Route("UpdateRoom/{id}")]
        public IActionResult UpdateRoom(Rooms room)
        {
            _roomService.TUpdate(room);
            return RedirectToAction("RoomList");
        }
    }
}