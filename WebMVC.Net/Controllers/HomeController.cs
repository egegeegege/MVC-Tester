using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Net.Models;

namespace WebMVC.Net.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			User user = new User();
			user.Name = "Ege";
			user.CountryList = GetCountry();
			return View(user);
		}

		[HttpPost]
		public IActionResult Submit(User user)
		{
			var test = ModelState.IsValid;
			if (ModelState.IsValid)
			{
				ViewBag.user = $"Name: {user.Name} Age:{user.Age} Gender{user.Gender} Country{user.Country}";
				return View("Result");
			}
			return View("Index");
		}

		public IActionResult Result()
		{
			return View();
		}
		public IEnumerable<SelectListItem> GetCountry()
		{
			return new SelectListItem[]
			{
				new SelectListItem {Value ="TR" , Text = "Turkey"},
				new SelectListItem {Value = "EN" , Text = "England"},
				new SelectListItem {Value = "GR" , Text = "Greece"},
				new SelectListItem {Value = "BL" , Text = "Bulgaria"},
			};
		}
	}
}
