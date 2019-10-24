using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class PinController : Controller
    {
        public IActionResult Index()
        {
            // Imamo objekt koji služi za povezivanje 
            ViewBag.Pin = "Pin je super, učim ga svaki dan...";
            ViewBag.Title = "PIN";
            return View();
        }

        public IActionResult Ajmo()
        {
            // Možemo naizmjence koristiti ViewData i ViewBag
            ViewData["ajme"] = "Idemo vježbati za kolokvij...";
            return View();
        }

    }
}
