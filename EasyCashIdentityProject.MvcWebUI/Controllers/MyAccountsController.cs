using EasyCashIdentityProject.DTO.Dtos.AppUserDtos;
using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name=value.Name;
            appUserEditDto.Surname = value.Surname;
            appUserEditDto.PhoneNumber = value.PhoneNumber;
            appUserEditDto.Email = value.Email;
            appUserEditDto.City = value.City;
            appUserEditDto.District=value.District;
            appUserEditDto.ImageUrl = value.ImageUrl;

            return View(appUserEditDto);
        }
        //[HttpPost]
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
