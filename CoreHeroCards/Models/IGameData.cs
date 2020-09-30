using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreHeroCards.Models
{
    public interface IGameData
    {
        public List<Deck> GetDecks(long playerID);
        public Deck GetDeck(long deckID);
        public List<HeroDoll> GetDolls(long playerID);
        public HeroDoll GetDoll(long dollID);
        public List<HeroActionCard> GetLibrary();
        public List<HeroActionCard> GetCollection(long playerID);
        public void CreateDeck(Deck deck);
        public void CreateDoll(HeroDoll doll, long playerID);
        public void DeleteDeck(long deckNumber);
        public void DeleteDoll(long dollID);
        public long CreatePlayer(Player newplayer);
        public long GetPlayerID(string userName);
        public Player GetPlayer(long playerID);
        public List<long> GetDeckIDs(long playerID);
        public HeroActionCard GetCardByCollectionID(long playerID, long collectionID);
    }
}
