using MediatR;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Context;
using OtelRezervasyon.EntityLayer.Concrete;
using OtelRezervasyon.MediatorPattern.Queries;
using OtelRezervasyon.Models;

namespace OtelRezervasyon.Controllers
{
    public class UILayoutController : Controller
    {
        private readonly IMediator _mediator;
        private readonly HotelContext _hotelContext;
        private readonly IContactService _contactService;

        public UILayoutController(HotelContext hotelContext, IMediator mediator, IContactService contactService)
        {
            _hotelContext = hotelContext;
            _mediator = mediator;
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SearchRooms()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchRooms(SearchViewModel model)
        {
            var result = await _mediator.Send(new SearchRoomQuery(model.EntryDate, model.ReleaseDate));
            return View(result);
        }

       
       
    }
}
