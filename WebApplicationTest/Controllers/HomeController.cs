using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<string> nicholeList = new List<string>{ "Nikkole", "Nikhole", "Ny'kole", "Nycole", "Nicholle", "Nacole", "Nachole", "Nicchole" };
            string randNichole = nicholeList.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            //Random rnd = new Random();
            //int r = rnd.Next(nicholeList.Count);
            ViewBag.RandNicholeName = randNichole;
            return View("Index");
        }
    }
}