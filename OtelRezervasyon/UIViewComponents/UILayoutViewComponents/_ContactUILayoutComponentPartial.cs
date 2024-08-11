using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.BusinessLayer.Abstracts;
using OtelRezervasyon.EntityLayer.Concrete;

namespace OtelRezervasyon.UIViewComponents.UILayoutViewComponents
{
    public class _ContactUILayoutComponentPartial : ViewComponent
    {
        private readonly IContactService _contactService;

        public _ContactUILayoutComponentPartial(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            //if (ModelState.IsValid)
            //{
            //    _contactService.TInsert(new Contact()
            //    {
            //        Name = contact.Name,

            //        Email = contact.Email,
            //        Message = contact.Message,
            //        Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
            //    });

            //    return View("Index", "UILayout");
            //}
            return View();
        }
    }
}
