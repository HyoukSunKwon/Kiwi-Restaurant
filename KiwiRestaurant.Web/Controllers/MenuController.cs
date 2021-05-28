using KiwiRestaurant.Data.Models;
using KiwiRestaurant.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KiwiRestaurant.Web.Controllers
{
    public class MenuController : Controller
    {
        private IFoodData db;
        public MenuController(IFoodData db)
        {
            this.db = db;
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
              
            if ( model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpGet]
        //[Authorize(Roles = "Coordinator")]
        public ActionResult Delete(int id) 
        {
            var model = db.Get(id);
           
            if ( model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        //[Authorize(Roles = "Coordinator")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);   
            return RedirectToAction("Index");
        }


        [HttpGet]
        //[Authorize(Roles = "Coordinator")]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if ( model == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Food food)
        {
            if(ModelState.IsValid)
            {
                db.Update(food);
                return RedirectToAction("Details", new { id = food.Id });
            }
            return View(food);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Coordinator")]
        public ActionResult Create(Food food)
        {
            if (ModelState.IsValid)
            {
                db.Add(food);
                return RedirectToAction("Details" , new { id = food.Id });
            }

            return View();
        }
    }
}