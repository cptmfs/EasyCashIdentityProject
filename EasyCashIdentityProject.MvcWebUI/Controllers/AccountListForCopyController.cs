using EasyCashIdentityProject.Business.Abstract;
using EasyCashIdentityProject.DataAccess.Concrete;
using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    public class AccountListForCopyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountService _customerAccountService;

        public AccountListForCopyController(UserManager<AppUser> userManager, ICustomerAccountService customerAccountService)
        {
            _userManager = userManager;
            _customerAccountService = customerAccountService;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var context = new Context();

            var values = _customerAccountService.GetCustomerAccountsListService(user.Id);
            return View(values);
        }
    }
}
