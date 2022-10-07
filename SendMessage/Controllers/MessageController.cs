using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SendMessage.Models.Concrete;
using System.Linq;

namespace SendMessage.Controllers
{
    public class MessageController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetList()
        {   
            var values = JsonConvert.SerializeObject(c.Messages.ToList());
            return Json(values);
        }
        public IActionResult MessageAdd(Message m)
        {
            c.Add(m);
            c.SaveChanges();
            var values = JsonConvert.SerializeObject(m);
            return Json(values);
        }

    }
}
