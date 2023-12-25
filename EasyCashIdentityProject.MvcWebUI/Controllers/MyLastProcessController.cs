using EasyCashIdentityProject.Business.Abstract;
using EasyCashIdentityProject.DataAccess.Concrete;
using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    public class MyLastProcessController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public MyLastProcessController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }


        public async Task< IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();
            int id=context.CustomerAccounts.Where(x=>x.AppUserID == user.Id && x.CustomerAccountCurrency=="Türk Lirası").Select(y=>y.CustomerAccountID).FirstOrDefault();
            var aliciGondericiOlunanIslemler = _customerAccountProcessService.MyLastProcessService(id);
            return View(aliciGondericiOlunanIslemler);
        }
    }
}
