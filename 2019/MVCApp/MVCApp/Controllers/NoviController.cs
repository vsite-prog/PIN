using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class NoviController : Controller
    {
        public string Index()
        {
            return "Pozdrav iz kontrolera";
        }

        public ActionResult Druga()
        {
            return Ok("POzdrav iz druge akcije!");
        }

        public string Treca(int a, string b)
        {

            return HtmlEncoder.Default.Encode($"Broj: {a} Text: {b}");
           // nije pametno ne escepa-ti korisnički unos return $"Broj: {a} Text: {b}";
        }

        public ActionResult Cetvrta(string txt)
        {
            ViewData["podatak"] = "Ja sam podatak ";
            ViewBag.par = txt;
            return View();
        }
    }
}