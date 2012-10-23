using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC3Tests.Models;

namespace MVC3Tests.Controllers
{
    public class FundController : Controller
    {

        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //
        // GET: /Fund/Create

        public ActionResult Create()
        {
            Repository repository = new Repository();
            Fund model = new Fund();
            PopulateViewBag();
            return View(model);
        } 

        
        //POST: /Fund/Create

        [HttpPost]
        public ActionResult Create(Fund fund)
        {
            if(ModelState.IsValid)
            {
                Repository repository = new Repository();
                repository.Funds.Add(fund);
                return RedirectToAction("Index", "Home");
            }
            PopulateViewBag();
            return View(fund);
            
        }
        
        //
        // GET: /Fund/Edit/5
 
        public ActionResult Edit(int id)
        {
            Repository repository = new Repository();
            Fund model = repository.Funds.Single(f => f.ID == id);
            PopulateViewBag();
            return View(model);
        }

        //
        // POST: /Fund/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            Repository repository = new Repository();
            Fund fund = repository.Funds.Single(f => f.ID == id);
            if(TryUpdateModel(fund))
            {
                return RedirectToAction("index", "Home");
            }
            else
            {
                PopulateViewBag();
                return View(fund);    
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

        private void PopulateViewBag()
        {
            Repository repository = new Repository();
            ViewBag.Managers = repository.Managers;
            ViewBag.Strategies = repository.Strategies;
        }
    }
}
