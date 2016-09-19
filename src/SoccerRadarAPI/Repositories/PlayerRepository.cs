using SoccerRadarAPI.Models.Players;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Repositories
{
    public class PlayerRepository : IReadOnlyRepository<Player>
    {
        private static ConcurrentDictionary<string, Player> _playas = new ConcurrentDictionary<string, Player>();

        private const string player1 = "player1";
        private const string player2 = "player2";
        private const string player1Id = "d4c5a0cf-6581-42d3-92a3-d3f0528663eb";
        private const string player2Id = "464fe9d5-a520-4d29-b538-41f6bb335b8e";

        public PlayerRepository()
        {
            _playas.TryAdd(player1, new Player(player1Id)
            {
                id = "d4c5a0cf-6581-42d3-92a3-d3f0528663eb",
                first_name = "Idriss",
                last_name = "Saadi",
                country_code = "FRA",
                country = "France",
                reference_id = "sr:player:102291",
                position = "F",
                rank = "1"
            });

            _playas.TryAdd(player2, new Player(player2Id)
            {
                id = "464fe9d5-a520-4d29-b538-41f6bb335b8e",
                first_name = "Herve",
                last_name = "Kage",
                country_code = "COD",
                country = "Democratic Republic of the Congo",
                reference_id = "sr:player:21923",
                position = "M",
                rank = "2"
            });
        }

        public Player Find(string key)
        {
            Player player;

            _playas.TryGetValue(key, out player);

            return player;
        }

        public IEnumerable<Player> GetAll()
        {
            return _playas.Values;
        }
    }
}
