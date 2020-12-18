using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BareCoreProject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return Ok("Pozdrav iz kontrolera!");
            // return View();
        }

        [HttpGet("/Druga")]
        public IActionResult Druga()
        {
            return View();
        }
    }
}
