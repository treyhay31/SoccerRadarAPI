using System;

namespace SoccerRadarAPI.Models
{
    public class Team
    {
        public Int16 goals { get; set; }
        public Int16 matches { get; set; }
        public string alias { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string full_name { get; set; }
        public string id { get; set; }
        public string is_manager { get; set; }
        public string is_player { get; set; }
        public string jersey_number { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string reference_id { get; set; }
        public string substituted_in { get; set; }
        public string type { get; set; }
    }
}