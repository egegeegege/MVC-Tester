using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using model_Binding.Models;
using model_Binding.ViewModel;

namespace model_Binding.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult HomePage()
		{

			Kisi kisi = new Kisi()
			{
				Ad = "Ege",
				Soyad = "Aydýn",
				Yas = 16
			};

			return View(kisi);
		}

		public IActionResult HomePage2()
		{
			Kisi kisi = new Kisi()
			{
				Ad = "Ege",
				Soyad = "Aydýn",
				Yas = 16
			};
			Adres adres = new Adres()
			{
				AdresTanim="Kadýköy/Kozyataðý/19 Mayýs Mah./Ýnönü Caddesi/Sümer Sokak/ Sümko Sitesi/ M2 B-blok",
				Sehir="Ýstanbul"
			};

			HomePadeViewModel homePadeViewModel = new HomePadeViewModel();
			homePadeViewModel.AdresBilgisi=adres;
			homePadeViewModel.KisiBilgisi=kisi;

			return View(homePadeViewModel);
		}


	}
}
