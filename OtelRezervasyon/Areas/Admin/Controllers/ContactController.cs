using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.DataAccessLayer.Abstract;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Contact/")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IContactDal _contactDal;

        public ContactController(IContactService contactService, UserManager<AppUser> userManager, IContactDal contactDal)
        {
            _contactService = contactService;
            _userManager = userManager;
            _contactDal = contactDal;
        }
        [Route("")]
        [Route("ContactList")]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetListAll();
            return View(values);
        }

        //[HttpGet]
        //public IActionResult CreateContact()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateContact(Contact contact)
        //{
        //    var user = await _userManager.FindByNameAsync(User.Identity.Name);
        //    contact.ContactId = user.Id;
        //    contact.Name = user.Name;
        //    contact.Email = user.Email;

        //    _contactService.TInsert(contact);
        //    return RedirectToAction("ContactList");
        //}
        [HttpGet]
        [Route("RemoveContact/{id}")]
        public IActionResult RemoveContact(int id)
        {
            var contact = _contactService.TGetById(id);

            _contactService.TDelete(id);

            return RedirectToAction("ContactList");
        }


        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = _contactService.TGetById(id);
            var model = new Contact
            {
                ContactId = value.ContactId,
                Name = value.Name,
                Email = value.Email,
               
                Message = value.Message
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = _contactService.TGetById(contact.ContactId);
            value.ContactId = contact.ContactId;
            value.Name = contact.Name;
            value.Email = contact.Email;
           
            value.Message = contact.Message;
            _contactService.TUpdate(value);
            return RedirectToAction("ContactList");

        }
    }
}
