using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreMVCApp.Controllers
{
    public class DrugiController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<string> studenti = new List<string>()
            {
                "Ante Antić",
                 "Ana Antić",
                 "Ante Antić",
                    "Ante Matić"
            };

            ViewBag.studenti = studenti;
            return View();
        }

        // GET: /<controller>/
        public IActionResult Druga()
        {
            return View();
        }
    }
}
