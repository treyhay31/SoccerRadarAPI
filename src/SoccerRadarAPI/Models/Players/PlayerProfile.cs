using System;

namespace SoccerRadarAPI.Models.Players
{
    public class PlayerProfile
    {
        public string xmlns { get; set; }
        public DateTime generated { get; set; }
        public Player player { get; set; }
    }
}