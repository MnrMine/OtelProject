using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;

namespace OtelRezervasyon.UIViewComponents.UILayoutViewComponents
{
    public class _OurRoomUILayoutComponentPartial : ViewComponent
    {

        private readonly IRoomService _roomService;

        public _OurRoomUILayoutComponentPartial(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IViewComponentResult Invoke()
        {
            var rooms = _roomService.TGetListAll();
            return View(rooms);
        }
    }
}
