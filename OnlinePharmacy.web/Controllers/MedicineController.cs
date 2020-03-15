using OnlinePharmacy.Data;
using OnlinePharmacy.Data.Models;
using OnlinePharmacy.Data.Services;
using OnlinePharmacy.Data.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlinePharmacy.web.Controllers
{
    public class MedicineController : Controller
    {
        IMedicine db = new MedicineService(new OnlinePharmacyContext());
        // GET: Medicine
        public ActionResult Index()
        {
            var data = db.GetAll();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Medicine medicine)
        {
            if(ModelState.IsValid)
            {
                db.Add(medicine);
                return RedirectToAction("Details", new { id = medicine.MedicineId });
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
            if (model == null)
            {
                return View("NotFound");
            }
            return PartialView("Edit");
        }

        [HttpPost]
        public ActionResult Edit(Medicine medicine)
        {
            if (ModelState.IsValid)
            {
                db.Update(medicine);
                return RedirectToAction("Details", new { id = medicine.MedicineId });
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