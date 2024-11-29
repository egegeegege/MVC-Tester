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
				Soyad = "Ayd�n",
				Yas = 16
			};

			return View(kisi);
		}

		public IActionResult HomePage2()
		{
			Kisi kisi = new Kisi()
			{
				Ad = "Ege",
				Soyad = "Ayd�n",
				Yas = 16
			};
			Adres adres = new Adres()
			{
				AdresTanim="Kad�k�y/Kozyata��/19 May�s Mah./�n�n� Caddesi/S�mer Sokak/ S�mko Sitesi/ M2 B-blok",
				Sehir="�stanbul"
			};

			HomePadeViewModel homePadeViewModel = new HomePadeViewModel();
			homePadeViewModel.AdresBilgisi=adres;
			homePadeViewModel.KisiBilgisi=kisi;

			return View(homePadeViewModel);
		}


	}
}
