using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3Tests.Models;

namespace MVC3Tests.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            IEnumerable<Manager> model = new SystemEntities().Managers.Include("Funds").OrderBy(M=>M.Name);
            return View(model);
        }
    }
}
