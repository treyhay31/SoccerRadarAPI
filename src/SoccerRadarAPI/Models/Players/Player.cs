using System;
using System.Collections.Generic;

namespace SoccerRadarAPI.Models.Players
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

        public List<PlayerStatistic> statistics { get; set; }
        public List<Team> teams { get; set; }
        public string birthdate { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string first_name { get; set; }
        public string full_first_name { get; set; }
        public string full_last_name { get; set; }
        public string height_cm { get; set; }
        public string height_in { get; set; }
        public string id { get; set; } = string.Empty;
        public string last_name { get; set; }
        public string position { get; set; }
        public string rank { get; set; }
        public string reference_id { get; set; }
        public string weight_kg { get; set; }
        public string weight_lb { get; set; }
        public Total total { get; set; }
    }

    public class Total
    {
        public Int16 matches { get; set; }
        public Int16 goals { get; set; }
        public Int16 substituted_in { get; set; }
    }
}