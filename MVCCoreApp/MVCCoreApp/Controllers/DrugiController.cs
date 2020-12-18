using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MVCCoreApp.Controllers
{
    public class DrugiController : Controller
    {
        public ActionResult Index()
        {
            // return "Pozdrav iz Drugog kontrolera!";

            return Ok("Sve je OK, pozdrav iz drugoga!");
        }

        public string Student(string ime, int godina )
        {
            // return $"Student imena: {ime} je na {godina}. godini faksa"; mogao bi injektirati nešto u stranicu
            return HtmlEncoder.Default.Encode($"Student imena: {ime} je na {godina}. godini faksa");
        }

        public ActionResult Stranica()
        {
            return View();
        }
    }
}
