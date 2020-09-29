using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHeroCards.Models
{
    public interface IGameData
    {
        public List<long> GetDecks(long playerID);
        public Deck GetDeck(long deckID);
        public List<HeroDoll> GetDolls(long playerID);
        public HeroDoll GetDoll(long dollID);
        public List<HeroActionCard> GetLibrary();
        public List<HeroActionCard> GetCollection(long playerID);
        public void CreateDeck(Deck deck);
        public void CreateDoll(HeroDoll doll);
        public void DeleteDeck(long deckNumber);
        public void DeleteDoll(long dollID);

    }
}
