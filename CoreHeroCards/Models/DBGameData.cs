using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace CoreHeroCards.Models
{
    public class DBGameData : IGameData
    {

        // const string server = "7RP7Q13\\SQLEXPRESS;Database=HeroCards;user id = csharp; password=abc123";

        IDbConnection db;

        public DBGameData(IConfiguration config)
        {
            db = new SqlConnection(config.GetConnectionString("DbServer"));
        }

        public void CreateDeck(Deck deck, long playerID)
        {
            // IDbConnection db = new SqlConnection(server);
            foreach(HeroActionCard card in deck.Cards)
            {
                db.Query($"insert into Deck (PlayerID, CollectionID, DeckNumber, Name) Values ('{playerID}','{card.CollectionID}', '{deck.DeckNumber}', '{deck.Name}')");
            }
        }

        public void CreateDeck(Deck deck)
        {
            throw new NotImplementedException();
        }

        public void CreateDoll(HeroDoll doll, long playerID)
        {
            // IDbConnection db = new SqlConnection(server);
            db.Insert(doll);
        }

        public void CreateDoll(HeroDoll doll)
        {
            throw new NotImplementedException();
        }

        public long CreatePlayer(Player newplayer)
        {
            // IDbConnection db = new SqlConnection(server);
            long playerID = db.Insert(newplayer);
            return (playerID);
        }

        public void DeleteDeck(long deckNumber)
        {
            // IDbConnection db = new SqlConnection(server);
            db.Query($"Delete from Deck where DeckNumber = {deckNumber}");
        }

        public long GetPlayerID(string userName)
        {
            // IDbConnection db = new SqlConnection(server);
            long playerID;
            try
            {
                playerID = db.QuerySingle<long>($"select PlayerID from Player where Name = '{userName}'");
            }
            catch
            {
                playerID = -1;
            }
            return playerID;
        }

        public void DeleteDoll(long dollID)
        {
            // IDbConnection db = new SqlConnection(server);
            db.Query($"Delete from HeroDoll where id = {dollID}");
        }

        public List<HeroActionCard> GetCollection(long playerID)
        {
            List<HeroActionCard> playerCollection = new List<HeroActionCard>();
            // IDbConnection db = new SqlConnection(server);
            playerCollection = db.Query<HeroActionCard>($"select * from CardCollection join HeroActionCard on CardCollection.cardID = HeroActionCard.card_id where playerID = {playerID}").AsList<HeroActionCard>();
            return playerCollection;
        }

        //This method relies on GetCardbyCollectionID
        public Deck GetDeck(long DeckID)
        {
            Deck thisDeck = new Deck();
            List<long> collectionIDs = new List<long>();
            long playerID;

            //Get Deck Name
            thisDeck.Name = db.Query($"select distinct Name from Deck where DeckNumber = {DeckID}").ToString();
            // Get Player ID
            playerID = db.QuerySingle($"select distinct PlayerID from Deck where DeckNumber = {DeckID}");
            //Get collection ID's
            collectionIDs = db.Query<long>($"select CollectionID from Deck where DeckNumber = {DeckID}").AsList<long>();
            //Get Cards from player collection
            foreach (long id in collectionIDs)
            {
                thisDeck.Cards.Add(GetCardByCollectionID(id));
            }
            //thisDeck.Cards = db.Query


            return thisDeck;
        }

        //This method relies on GetDeck and GetDeckID's by extension GetDeck relies on GetCardbyCollectionID
        public List<Deck> GetDecks(long playerID)
        {
            List<long> deckids = GetDeckIDs(playerID);
            List<Deck> playerdecks = new List<Deck>();
            foreach(long deckid in deckids)
            {
                playerdecks.Add(GetDeck(deckid));
            }
            return playerdecks;
        }

        public List<long> GetDeckIDs (long playerID)
        {
            List<long> playerDecks = new List<long>();
            // IDbConnection db = new SqlConnection(server);
            playerDecks = db.Query<long>($"Select DeckNumber from Deck where PlayerID ={playerID}").AsList<long>();
            return playerDecks;
        }

        public HeroDoll GetDoll(long dollID)
        {
            // IDbConnection db = new SqlConnection(server);
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

        public Player GetPlayer(long playerID)
        {
            Player thisplayer = db.Get<Player>(playerID);
            return thisplayer;
        }

        List<long> IGameData.GetDecks(long playerID)
        {
            throw new NotImplementedException();
        }

        public HeroActionCard GetCardByCollectionID(long collectionID)
        {
            throw new NotImplementedException();
        }
    }
}
