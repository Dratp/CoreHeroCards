using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHeroCards.Models;

namespace CoreHeroCards.Controllers
{
    public class PlayerController : Controller
    {
        private IGameData _data;

        public PlayerController(IGameData data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Collection(long playerID)
        {
            Player current = Player.AssemblePlayer(playerID, _data);
            return View("Collection", current);
        }
    }
}
