using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
