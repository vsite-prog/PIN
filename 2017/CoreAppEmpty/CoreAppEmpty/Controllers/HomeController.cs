using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreAppEmpty.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            //return Ok("Haj, haj, idemoooo...");
            return View();
        }

        [Route("/Druga/")]
        public IActionResult Druga()
        {
            return View();
        }
    }
}
