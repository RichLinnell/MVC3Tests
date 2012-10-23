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
            SystemEntities repository = new SystemEntities();
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
                SystemEntities repository = new SystemEntities();
                repository.Funds.Add(fund);
                repository.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            PopulateViewBag();
            return View(fund);
            
        }
        
        //
        // GET: /Fund/Edit/5
 
        public ActionResult Edit(int id)
        {
            SystemEntities repository = new SystemEntities();
            Fund model = repository.Funds.Single(f => f.ID == id);
            PopulateViewBag();
            return View(model);
        }

        //
        // POST: /Fund/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            SystemEntities repository = new SystemEntities();
            Fund fund = repository.Funds.Find(id);
            if(TryUpdateModel(fund))
            {
                repository.SaveChanges();
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
            SystemEntities repository = new SystemEntities();
            ViewBag.Managers = repository.Managers;
            ViewBag.Strategies = repository.Strategies;
        }
    }
}
