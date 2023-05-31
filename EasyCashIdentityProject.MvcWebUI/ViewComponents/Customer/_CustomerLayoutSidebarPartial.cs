using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
