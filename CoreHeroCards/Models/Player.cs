using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHeroCards.Models
{
    public class Player
    {
        public long PlayerID { get; set; }
        public string Name { get; set; }
        public int Currency { get; set; }
        public List<HeroDoll> Dolls { get; set; }
        public List<Deck> Decks { get; set; }


        public static Player Create(string userName)
        {
            return null;
        }

    }
}
