using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
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

        public ActionResult Kayitol(Musteri musteri)
        {
            c.Musteris.Add(musteri);
            c.SaveChanges();
            return View();
        }

    }
}