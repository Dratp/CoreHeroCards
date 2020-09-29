using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHeroCards.Models;

namespace CoreHeroCards.Controllers
{
    public class BattleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Battle(List<Participant> Players)
        {
            return View();
        }

    }
}
