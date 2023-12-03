using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.Controllers
{
	public class HangHoaController : Controller
	{
		public IActionResult Index(int? loai)
		{
			return View();
		}
	}
}
