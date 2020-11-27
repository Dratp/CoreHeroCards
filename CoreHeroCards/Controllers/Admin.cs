using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreHeroCards.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace CoreHeroCards.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CreateCardMenu()
        {
            return View();
        }

        public IActionResult CreateCard(string cardName, string rarity ,int playSpeed, string actionText, int manaCost, int healthCost, int timeCost, string target, int physAtk, bool slashing, int slashBleed, int slashBleedDuration, bool piercing, int pierceArmor, bool bludgeon, int bludegonLower, int bludegonLowerDuration, bool shield, int shieldArmor, int shieldResistance, int shieldDuration, int magicAtk, bool fire, int fireBurn, int fireBurnDuration, bool electric, int electricSpeed, bool ice, int iceSlow, int iceSlowDurability, bool earth, int earthAbsorb, bool holy, int holyHeal, bool dark, int darkSteal, bool taunt, bool dispel, int multi, int mana, string requires, string subRequires, bool hitModify, int hitModifyPhys, int hitModifyMagic, int HitModifyDuration)
        {
            HeroActionCard newCard = new HeroActionCard
            {
                CardName = cardName,
                PlaySpeed = playSpeed,
                ActionText = actionText,
                ManaCost = manaCost,
                HealthCost = healthCost,
                TimeCost = timeCost,
                Target = target,
                PhysAtk = physAtk,
                Slashing = slashing,
                SlashBleed = slashBleed,
                SlashBleedDuration = slashBleedDuration,
                Piercing = piercing,
                PierceArmor = pierceArmor,
                Bludgeon = bludgeon,
                BludgeonLower = bludegonLower,
                BludegonLowerDuration = bludegonLowerDuration,
                Shield = shield,
                ShieldArmor = shieldArmor,
                ShieldResistance = shieldResistance,
                ShieldDuration = shieldDuration,
                MagicAtk = magicAtk,
                Fire = fire,
                FireBurn = fireBurn,
                FireBurnDuration = fireBurnDuration,
                Electric = electric,
                ElectricSpeed = electricSpeed,
                Ice = ice,
                IceSlow = iceSlow,
                IceSlowDurability = iceSlowDurability,
                Earth = earth,
                EarthAbsorb = earthAbsorb,
                Holy = holy,
                HolyHeal = holyHeal,
                Dark = dark,
                DarkSteal = darkSteal,
                Taunt = taunt,
                Dispel = dispel,
                MultiCast = multi,
                Mana = mana
            };

            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=HeroCards;user id=csharp;password=abc123"))
            {
                 db.Query($"Insert Into [HeroActionCard] (CardName, Rarity, PlaySpeed, ActionText, ManaCost, HealthCost, TimeCost, Target, PhysAtk, Slashing, SlashBleed, SlashBleedDuration, Piercing, PierceArmor, Bludgeon, BludgeonLower, BludgeonLowerDuration, Shield, ShieldArmor, ShieldResistance, ShieldDuration, MagicAtk, Fire, FireBurn, FireBurnDuration, Electric, ElectricSpeed, Ice, IceSlow, IceSlowDurability, Earth, EarthAbsorb, Holy, HolyHeal, Dark, DarkSteal, Taunt, Dispel, MultiCast, ManaManipulate, Requires, SubRequirment, HitModify, HitModifyPhys, HitModifyMagic, HitModifyDuration) Values ('{cardName}','{rarity}','{playSpeed}','{actionText}','{manaCost}','{healthCost}','{timeCost}','{target}','{physAtk}','{slashing}','{slashBleed}','{slashBleedDuration}','{piercing}','{pierceArmor}','{bludgeon}','{bludegonLower}','{bludegonLowerDuration}','{shield}','{shieldArmor}','{shieldResistance}','{shieldDuration}','{magicAtk}','{fire}','{fireBurn}','{fireBurnDuration}','{electric}','{electricSpeed}','{ice}','{iceSlow}','{iceSlowDurability}','{earth}','{earthAbsorb}','{holy}','{holyHeal}','{dark}','{darkSteal}','{taunt}','{dispel}','{multi}','{mana}','{requires}','{subRequires}','{hitModify}','{hitModifyPhys}','{hitModifyMagic}','{HitModifyDuration}')");
            }

            return View(newCard);
        }

        public IActionResult ViewAllCards()
        {
            List<HeroActionCard> cards;
            using (IDbConnection db = new SqlConnection("Server=7RP7Q13\\SQLEXPRESS;Database=HeroCards;user id=csharp;password=abc123"))
            {
                cards = db.Query<HeroActionCard>("select * from [HeroActionCard]").AsList<HeroActionCard>();
            }

            return View(cards);
        }
    }
}
