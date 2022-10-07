using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class EkHizmetController : Controller
    {
        // GET: EkHizmet
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

        public ActionResult Kayitol(EkHizmet eh)
        {
            c.ekHizmets.Add(eh);
            c.SaveChanges();
            return View();
        }

    }
}