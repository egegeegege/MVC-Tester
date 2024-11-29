using System.Collections;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCWebAplication1.Models;

namespace MVCWebAplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Ad"] = "Ege";

            ArrayList list = new ArrayList();
            list.Add("Hello World");
            list.Add("Hello People");

            ViewBag.liste = list;

            TempData ["Ýsim"] = "Zeynep Ayda Yanar";

            return View();
        }

        [HttpPost]
        public IActionResult Index(string Kisiler,string Ad , bool Onay)
        {
            var k1 = Request.Form["Kisiler"];
            var j1 = Request.Form["Onay"];
            var h1 = Request.Form["Ad"];

            ViewBag.Name = j1;
            return View();
        }
        public IActionResult About()
        {
            TempData["Name"] = TempData["Ýsim"];
            return View();
        }
    }
}
