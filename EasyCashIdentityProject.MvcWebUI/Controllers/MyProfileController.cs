using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
