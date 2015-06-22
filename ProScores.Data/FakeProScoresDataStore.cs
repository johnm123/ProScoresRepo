using System;
using System.Collections.Generic;


using ProScores.Objects;

namespace ProScores.Data
{
    public class FakeProScoresDataStore : IProScoresDataStore
    {
        public IEnumerable<ProEvoResult> GetAll()
        {
            return GetFakeResults();
        }

        public IEnumerable<Player> GetAllPlayers()
        {
            var players = new List<Player>
            {
                new Player() {NickName = "Rimmer", Name = "Shaun"},
                new Player() {NickName = null, Name = "Jabroni"},
                new Player() {NickName = "The King", Name = "John.M"}
            };
            return players;
        }

        public ProEvoResult CreateOrModify(ProEvoResult result)
        {
            result.Id = 555;
            return result;
        }

        public Player Create(Player player)
        {
            return player;
        }

        public void Delete(int id)
        {
        }

        private static List<ProEvoResult> GetFakeResults()
        {
            return new List<ProEvoResult>()
            {
                new ProEvoResult()
                {
                    Id = 1,
                    PlayerHome = "Shaun",
                    TeamHome = "Chelsea",
                    GoalsHome = 0,
                    PlayerAway = "John.M",
                    TeamAway = "Real Madrid",
                    GoalsAway = 5,
                    Comments = "Easy",
                    Date = DateTime.Now
                },
                new ProEvoResult()
                {
                    Id = 2,
                    PlayerHome = "Shaun",
                    TeamHome = "Chelsea",
                    GoalsHome = 1,
                    PlayerAway = "John.M",
                    TeamAway = "Real Madrid",
                    GoalsAway = 3,
                    Comments = "Easy still",
                    Date = DateTime.Now
                },
            };
        }
    }
}