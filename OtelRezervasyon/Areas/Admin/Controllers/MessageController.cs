using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.DataAccessLayer.EntityFramework;

namespace OtelRezervasyon.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Message/")]
    public class MessageController : Controller
    {
        //EfContactDal ef = new EfContactDal();

        //[Route("")]
        //[Route("Inbox")]
        //public IActionResult Inbox()
        //{
        //    var messagelist = ef.GetListAll();
        //    return View(messagelist);
        //}

        //public IActionResult Inbox2()
        //{
        //    var messagelist = ef.GetListAll();
        //    return View(messagelist);
        //}
    }
}
