using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Net_View_Layout.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}
