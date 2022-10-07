using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class SporDaliController : Controller
    {
        // GET: SporDali
        public ActionResult Index()
        {
            return View();
        }
        Context c = new Context();
        [HttpGet]
        public ActionResult Kayitol()
        {

            return View();
        }

        [HttpPost]

        public ActionResult Kayitol(SporDali sd)
        {
            c.SporDalis.Add(sd);
            c.SaveChanges();
            return View();
        }

    }
}