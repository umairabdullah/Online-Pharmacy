using OnlinePharmacy.Data;
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

        CategoryService service = new CategoryService(new OnlinePharmacyContext());

        // GET: Category
        public ActionResult Index()
        {
            var data = service.GetAll();
            return View(data);
        }
    }
}