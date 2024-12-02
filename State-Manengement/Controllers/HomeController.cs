using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using State_Manengement.Models;

namespace State_Manengement.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			HttpContext.Session.SetString("Username", "Ege Aydýn");
			ViewBag.Username = HttpContext.Session.GetString("Username");

				var cookieoptions = new CookieOptions
				{
					Expires = DateTime.Now.AddMinutes(30),
					HttpOnly = true,
					IsEssential = true
				};

			Response.Cookies.Append("Username", "Ege Aydýn", cookieoptions);

			var cookieusername = Request.Cookies["Username"];

			ViewBag.cookieusername = cookieusername;
			return View();
		}
	}
}
