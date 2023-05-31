using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.ViewComponents.Customer
{
    public class _CustomerHeaderLayoutPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
