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
            var model = new List<Fund>
                            {
                                new Fund()
                                    {
                                        Code = "DKD",
                                        ID = 1,
                                        Name = "DK Distressed",
                                        ManagerID = 1,
                                        StrategyID = 1,
                                    },
                                new Fund()
                                    {
                                        Code = "LakeW",
                                        ID = 2,
                                        ManagerID = 2,
                                        Name = "Lakewood",
                                        StrategyID = 2,
                                    }
                            };
            return View(model);
        }
    }
}
