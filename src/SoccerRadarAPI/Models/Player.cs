using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Models
{
    public class Player
    {
        public Player()
        {
            id = string.IsNullOrEmpty(id) 
                ? Guid.NewGuid().ToString("D") 
                : id;
        }

        public Player(string playerId) : base()
        {
            Guid guid;

            if (Guid.TryParse(playerId, out guid))
            {
                id = guid.ToString("D");
            }
        }

        public string id { get; set; } = string.Empty;
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string reference_id { get; set; }
        public string position { get; set; }
        public string rank { get; set; }
        public List<Team> teams { get; set; }
        public Total total { get; set; }
    }

    public class Total
    {
        public Int16 matches { get; set; }
        public Int16 goals { get; set; }
        public Int16 substituted_in { get; set; }
    }
}
