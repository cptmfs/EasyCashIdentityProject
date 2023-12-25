using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
	public class ElectricBillController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
