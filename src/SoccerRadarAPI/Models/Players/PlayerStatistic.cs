namespace SoccerRadarAPI.Models.Players
{
    public class PlayerStatistic
    {
        public string goals { get; set; }
        public string goal_frequency { get; set; }
        public string goal_average { get; set; }
        public string goal_assists { get; set; }
        public string matches_played { get; set; }
        public string matches_started { get; set; }
        public string minutes_played { get; set; }
        public string yellow_cards { get; set; }
        public string yellow_red_cards { get; set; }
        public string red_cards { get; set; }
        public string substitutions_out { get; set; }
        public string substitutions_in { get; set; }
        public Category category { get; set; }
        public TournamentGroup tournament_group { get; set; }
        public Team team { get; set; }
        public Tournament tournament { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string name { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string reference_id { get; set; }
    }

    public class TournamentGroup
    {
        public string id { get; set; }
        public string name { get; set; }
        public string reference_id { get; set; }
    }

    public class Tournament
    {
        public string id { get; set; }
        public string name { get; set; }
        public string season_id { get; set; }
        public string type { get; set; }
        public string reference_id { get; set; }
    }

    public class Season
    {
        public string year { get; set; }
        public PlayerStatistic statistic { get; set; }
    }
}