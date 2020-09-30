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

        const int startMoney = 10000;


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

        public IActionResult RegisterUser(string userName)
        {
            Player noob = new Player() { Name = userName, Currency = startMoney };
            long id = _data.CreatePlayer(noob);
            noob = Player.AssemblePlayer(id, _data);

            return View("HomeScreen", noob);
        }

        public IActionResult UserCheck(string userName)
        {
            long id = _data.GetPlayerID(userName);
            if (id == -1)
            {
                ViewBag.Message = "There is no player by that name";
                return View("LoginPage");
            }

            Player active = Player.AssemblePlayer(id, _data);

            //return Content($"The user id is {id}");
            return View("HomeScreen", active);
            // Home screen just links to other parts of the game.. current ideas are DollShop, Battle, CardShop, DeckEdit, DollStats

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
