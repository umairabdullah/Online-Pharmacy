using OnlinePharmacy.Data;
using OnlinePharmacy.Data.Models;
using OnlinePharmacy.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlinePharmacy.web.Controllers
{
    public class CategoryController : Controller
    {

        ICategory db = new CategoryService(new OnlinePharmacyContext());
        

        // GET: Category
        public ActionResult Index()
        {
            var data = db.GetAll();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                db.Add(category);
                return RedirectToAction("Details", new { id = category.CategoryId });
            }
            return View();
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            if(model == null )
            {
                return View("NotFound");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if(ModelState.IsValid)
            {
                db.Update(category);
                return RedirectToAction("Details", new { id = category.CategoryId });
            }
            return View("Edit");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);

        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }

    }
}