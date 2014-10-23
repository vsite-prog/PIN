using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";
            //Dodajte našu poruku
            ViewData["Poruka"] = "Evo i na HR:Dobro nam došli!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Zivotinje()
        {
            //Aktiviraj model
            DatabaseEntities db = new DatabaseEntities();
            List<zivotinja> lista = db.zivotinja.ToList<zivotinja>();
            //Pošalji životinje prema viewu
            return View(lista);
        }
    }
}
