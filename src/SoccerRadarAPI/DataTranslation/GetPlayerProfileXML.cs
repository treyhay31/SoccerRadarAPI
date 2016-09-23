using SoccerRadarAPI.DataStore;
using SoccerRadarAPI.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SoccerRadarAPI.DataTranslation
{
    
    //https://api.sportradar.us/soccer-t2/eu/matches/[match_id]/boxscore.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/matches/[match_id]/summary.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/matches/[year]/[month]/[day]/boxscore.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/matches/[year]/[month]/[day]/schedule.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/matches/[year]/[month]/[day]/summary.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/matches/schedule.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/players/[player_id]/profile.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/players/leader.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/teams/[team_id]/profile.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/teams/hierarchy.xml?api_key=bkkv66h478c5pcbg3mm8s3mv
    //https://api.sportradar.us/soccer-t2/eu/teams/standing.xml?api_key=bkkv66h478c5pcbg3mm8s3mv

    public class GetXML<T>
    {
        private readonly HttpClient _http = new HttpClient();
        private const string urlPart1 = "https://api.sportradar.us/soccer-t2/eu/players/";
        private const string urlPart2 = "/profile.xml?api_key=bkkv66h478c5pcbg3mm8s3mv";
        private const string fakeId = "5feca71f-8ff3-404c-b7e8-37a77088b3f2";

        public PlayerProfile Find(string key)
        {
            //using (var req = _http.GetAsync($"{urlPart1}{key}{urlPart2}"))
            using (var req = _http.GetAsync($"{urlPart1}{fakeId}{urlPart2}").Result)
            {
                if (req.IsSuccessStatusCode)
                {
                    return new PlayerProfile();
                }

                throw new Exception(req.StatusCode.ToString());
            }
        }

        public IEnumerable<PlayerProfile> GetAll()
        {
            using (var req = _http.GetAsync($"{urlPart1}{fakeId}{urlPart2}").Result)
            {
                if (req.IsSuccessStatusCode)
                {
                    return new List<PlayerProfile>();
                }

                throw new Exception(req.StatusCode.ToString());
            }
        }

        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
