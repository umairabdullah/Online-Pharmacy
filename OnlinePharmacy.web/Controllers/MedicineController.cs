using OnlinePharmacy.Data;
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
    }
}