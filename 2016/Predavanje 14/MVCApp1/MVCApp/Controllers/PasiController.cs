using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class PasiController : Controller
    {
        PasiEntities db = new PasiEntities();
        // GET: Pasi
        public String Index()
        {
            return "<strong> Ovdje ide serija pasa</strong>";
        }

        // GET: Pasi/Lista
        public ActionResult Lista(int broj, string message)
        {
            ViewBag.broj = broj;
            ViewBag.message = message;
            return View( db.Pas.ToList<Pas>());
        }

        // GET: Pasi
        public ActionResult Edit(int id)
        {
            var pas = from p in db.Pas
                      where p.id == id
                      select p;
            return View(pas.First());
        }

    }
}