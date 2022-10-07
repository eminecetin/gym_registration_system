using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class CalismaSekliController : Controller
    {
        // GET: CalismaSekli
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

        public ActionResult Kayitol(CalismaSekli cs)
        {
            c.CalismaSeklis.Add(cs);
            c.SaveChanges();
            return View();
        }

    }
}