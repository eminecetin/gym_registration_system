using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SalonKayitSistemi.Models.Class;

namespace SalonKayitSistemi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hakkimizda()
        {
           
            return View();
        }

        public ActionResult Kayitol()
        {
            return View();
        }


   
    }
}