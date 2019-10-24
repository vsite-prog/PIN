using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreProject.Controllers
{
    public class HomeController : Controller
    {
        // Ovdje u atributu kažemo da spoji URL sa kontrolerom (MVC servis)
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("Pozdrav iz kontrolera!");
            //return View();
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}