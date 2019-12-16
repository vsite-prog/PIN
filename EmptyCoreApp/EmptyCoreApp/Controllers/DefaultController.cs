using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmptyCoreApp.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/drugi")]
        public IActionResult Drugi()
        {
            // Nemamo View
            return Ok("POzdrav iz kontrolera!");
        }
    }
}