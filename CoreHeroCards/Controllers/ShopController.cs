using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHeroCards.Models;

namespace CoreHeroCards.Controllers
{
    public class ShopController : Controller
    {
        private IGameData _data;

        public ShopController(IGameData data)
        {
            _data = data;
        }

        public IActionResult Index(long playerID)
        {
            Player current = Player.AssemblePlayer(playerID, _data);
            return View("HeroShop", current);
            //return Content($"the player ID is: {playerID}");
        }

        public IActionResult ShopNavigation(long playerID, string ShopNav)
        {
            Player current = Player.AssemblePlayer(playerID, _data);
            if (ShopNav == "DollBench")
            {
                return View("ChooseDoll", current);
            }
            else if (ShopNav == "DollCase")
            {
                return View("DollCase", current);
            }
            else
            {
                return RedirectToAction("CardTrader", current);
            }
        }

        public IActionResult WorkBench(long playerID, long UpgradeDollID)
        {
            HeroDoll doll = _data.GetDoll(UpgradeDollID);
            return View(doll);
        }

        public IActionResult CardTrader(Player current) 
        {
            ViewBag.PlayerID = current.PlayerID;
            List<HeroActionCard> fullLibrary = _data.GetLibrary();
            return View("CardCase", fullLibrary);
        } 
            
        public IActionResult BuyCards(long X, long card1, long card2, long card3, long playerID)
        {
            HeroActionCard theCard = _data.GetCardFromLibrary(X);
            _data.AddCardToCollection(playerID, theCard);
            return Content($"{X}");
        }

    }
}
