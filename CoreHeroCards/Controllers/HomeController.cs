using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreHeroCards.Models;

namespace CoreHeroCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IGameData _data;




        public HomeController(ILogger<HomeController> logger, IGameData data)
        {
            _logger = logger;
            _data = data;
        }

        public IActionResult Index()  // This --> LoginPageView --> HomePage or NewUser
        {
            return View("LoginPage");
        }

        public IActionResult NewUser()  // LoginPage --> This --> RegisterView --> RegisterAction
        {
            return View();
        }

        public IActionResult Register(string userName)
        {
            Player noob = Player.Create(userName);
            return View("Game/Home");

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
