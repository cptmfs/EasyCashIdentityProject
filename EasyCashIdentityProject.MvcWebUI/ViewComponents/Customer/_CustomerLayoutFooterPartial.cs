using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.ViewComponents.Customer
{
    public class _CustomerLayoutFooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
