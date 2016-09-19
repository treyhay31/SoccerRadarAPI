using SoccerRadarAPI.DataStore;
using SoccerRadarAPI.DataTranslation;
using SoccerRadarAPI.Models.Players;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Repositories
{
    public class PlayerRepository : IReadOnlyRepository<PlayerProfile>
    {
        private IData<PlayerProfile> _repository;

        public PlayerRepository()
        {
            _repository = new GetPlayerProfileXML();
        }

        public PlayerProfile Find(string key)
        {
            return _repository.Find(key);
        }

        public IEnumerable<PlayerProfile> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
