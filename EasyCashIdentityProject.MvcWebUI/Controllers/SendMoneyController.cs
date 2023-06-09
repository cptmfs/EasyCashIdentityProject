﻿using EasyCashIdentityProject.Business.Abstract;
using EasyCashIdentityProject.DataAccess.Concrete;
using EasyCashIdentityProject.DTO.Dtos.CustomerAccountProcessDtos;
using EasyCashIdentityProject.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.MvcWebUI.Controllers
{
    public class SendMoneyController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICustomerAccountProcessService _customerAccountProcessService;

        public SendMoneyController(UserManager<AppUser> userManager, ICustomerAccountProcessService customerAccountProcessService)
        {
            _userManager = userManager;
            _customerAccountProcessService = customerAccountProcessService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SendMoneyForCustomerAccountProcessDto sendMoneyForCustomerAccountProcessDto)
        {
            var context = new Context();

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var receiverAccountNumber = context.CustomerAccounts.Where(x => x.CustomerAccountNumber == sendMoneyForCustomerAccountProcessDto.ReceiverAccountNumber).Select(y => y.CustomerAccountID).FirstOrDefault();

            sendMoneyForCustomerAccountProcessDto.SenderID = user.Id;
            sendMoneyForCustomerAccountProcessDto.ProcessDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            sendMoneyForCustomerAccountProcessDto.ProcessType = "Havale";
            sendMoneyForCustomerAccountProcessDto.ReceiverID = receiverAccountNumber;
            //_customerAccountProcessService.TInsert();
            return RedirectToAction("Index", "Deneme");
        }
    }
}
