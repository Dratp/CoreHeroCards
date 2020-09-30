using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace CoreHeroCards.Models
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public long PlayerID { get; set; }
        public string Name { get; set; }
        public int Currency { get; set; }
        [Write(false)]
        public List<HeroDoll> Dolls { get; set; }
        [Write(false)]
        public List<Deck> Decks { get; set; }

        public static Player AssemblePlayer(long playerID, IGameData data)
        {
            Player activePlayer = data.GetPlayer(playerID);
            activePlayer.Decks = data.GetDecks(activePlayer.PlayerID);
            activePlayer.Dolls = data.GetDolls(activePlayer.PlayerID);

            return activePlayer;
        }


    }
}
