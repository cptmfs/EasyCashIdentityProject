using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
