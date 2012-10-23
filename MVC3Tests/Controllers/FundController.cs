using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3Tests.Controllers
{
    public class FundController : Controller
    {

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        ////
        //// GET: /Fund/Create

        //public ActionResult Create()
        //{
        //    return View();
        //} 

        //
        // POST: /Fund/Create

        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        
        //
        // GET: /Fund/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Fund/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index","Home");
            }
            catch
            {
                return View();
            }
        }

        //
        //// GET: /Fund/Delete/5
 
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        ////
        //// POST: /Fund/Delete/5

        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here
 
        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
