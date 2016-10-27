using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class PINController : Controller
    {
        // GET: PIN
        public ActionResult Index()
        {
            return View();
        }

        // GET: PIN/Onama
        public ActionResult Onama()
        {
            // Prepare data for View
            ViewBag.MessageFromController = "VSITE je super, uhuhuuuu...";
            return View();
        }
    }
}