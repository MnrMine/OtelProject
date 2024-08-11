using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.EntityLayer.Concrete;
using OtelRezervasyon.Models;

namespace OtelRezervasyon.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                _contactService.TInsert(new Contact()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Message = model.Message,
                    
                   
                 Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index", "UILayout");
            }
            return View(model);
        }
    }
        
    }

