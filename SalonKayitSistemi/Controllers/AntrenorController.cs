using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class AntrenorController : Controller
    {
        // GET: Antrenor
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

        public ActionResult Kayitol(Antrenor ant)
        {
            c.Antrenors.Add(ant);
            c.SaveChanges();
            return View();
        }

    }
}