using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;


namespace CoreHeroCards.Models
{
    public class DBGameData : IGameData
    {

        const string server = "7RP7Q13\\SQLEXPRESS;Database=HeroCards;user id = csharp; password=abc123";

        public void CreateDeck(Deck deck, long playerID)
        {
            IDbConnection db = new SqlConnection(server);
            foreach(HeroActionCard card in deck.Cards)
            {
                db.Query($"insert into Deck (PlayerID, CollectionID, DeckNumber, Name) Values ('{playerID}','{card.CollectionID}', '{deck.DeckNumber}', '{deck.Name}')");
            }
        }

        public void CreateDoll(HeroDoll doll, long playerID)
        {
            IDbConnection db = new SqlConnection(server);
            db.Insert(doll);
        }

        public void DeleteDeck(long deckNumber)
        {
            IDbConnection db = new SqlConnection(server);
            db.Query($"Delete from Deck where DeckNumber = {deckNumber}");
        }

        public void DeleteDoll(long dollID)
        {
            IDbConnection db = new SqlConnection(server);
            db.Query($"Delete from HeroDoll where id = {dollID}");
        }

        public List<HeroActionCard> GetCollection(long playerID)
        {
            List<HeroActionCard> playerCollection = new List<HeroActionCard>();
            IDbConnection db = new SqlConnection(server);
            playerCollection = db.Query<HeroActionCard>($"select * from CardCollection join HeroActionCard on CardCollection.cardID = HeroActionCard.card_id where playerID = {playerID}").AsList<HeroActionCard>();
            return playerCollection;
        }

        public Deck GetDeck(long DeckID)
        {
            throw new NotImplementedException();
        }

        public List<long> GetDecks(long playerID)
        {
            List<long> playerDecks = new List<long>();
            IDbConnection db = new SqlConnection(server);
            playerDecks = db.Query<long>($"Select DeckNumber from Deck where PlayerID ={playerID}").AsList<long>();
            return playerDecks;
        }

        public HeroDoll GetDoll(long dollID)
        {
            IDbConnection db = new SqlConnection(server);
            HeroDoll doll = db.QuerySingle<HeroDoll>($"select * from HeroDoll where id = {dollID}");
            return doll;
        }

        public List<HeroDoll> GetDolls(long playerID)
        {
            throw new NotImplementedException();
        }

        public List<HeroActionCard> GetLibrary()
        {
            throw new NotImplementedException();
        }


    }
}
