using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Predavanje_14.Controllers
{
    public class NestoController : Controller
    {
        // GET: Nesto
        public string Index()
        {
            return "<strong> Naš prvi MVC 5 kontroler";
        }

        // GET: Nesto/Nesto
        public ActionResult Nesto(string msg, int? broj)
        {
            //Ove parametere koje primaš preko URL-a proslijedi view-u
            ViewBag.msg = msg;
            ViewBag.broj = broj;
            return  View();
        }
    }
}