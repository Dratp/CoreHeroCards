﻿using System;
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
            _data.ClearShop();
            FillCardShop(3);
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
            List<HeroActionCard> shopcards = _data.AllShopCards();
            return View("CardCase", shopcards);
        } 
            
        public IActionResult BuyCards(long X, long playerID)
        {

            HeroActionCard theCard = GetCardFromShop(X);
            _data.AddCardToCollection(playerID, theCard);
            _data.DeleteCardFromShop(theCard);
            Player current = Player.AssemblePlayer(playerID, _data);
            return RedirectToAction("CardTrader", current);
        }

        public void FillCardShop(int HowManyCards)
        {
            Random rand = new Random();
            List<HeroActionCard> fullLibrary = _data.GetLibrary();
            for (int i = 0; i < HowManyCards; i++)
            {
                _data.AddCardToShop(fullLibrary[rand.Next(0,fullLibrary.Count)]);
            }
        }

        public HeroActionCard GetCardFromShop(long ShopID)
        {
            List<HeroActionCard> ShopCards = _data.AllShopCards();
            HeroActionCard theCard = new HeroActionCard();
            foreach(HeroActionCard card in ShopCards)
            {
                if (card.ShopCardID == ShopID)
                {
                    theCard = card;
                }
            }
            return theCard;
        }

    }
}
