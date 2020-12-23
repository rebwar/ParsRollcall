using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParsRollcall.Application.Services.Users.Queries;
using ParsRollcall.Site.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ParsRollcall.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetUserLoginService service;

        public HomeController(ILogger<HomeController> logger, IGetUserLoginService service )
        {
            _logger = logger;
            this.service = service;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(UserLoginVwModel model)
        {
            var islogin = service.Execute(new GetUserLoginDto {
                UserName = model.UserName,
                Password = model.Password
            });
            
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
