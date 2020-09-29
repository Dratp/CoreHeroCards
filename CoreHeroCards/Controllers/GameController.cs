using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHeroCards.Models;

namespace CoreHeroCards.Controllers
{
    public class GameController : Controller
    {
        private IGameData _data;

        public GameController(IGameData data)
        {
            _data = data;
        }


        public IActionResult Index()
        {
            return View();
        }

        // Home screen just links to other parts of the game.. current ideas are DollShop, Battle, CardShop, DeckEdit, DollStats
        public IActionResult Home(Player activePlayer)
        {
            return View();
        }




    }
}
