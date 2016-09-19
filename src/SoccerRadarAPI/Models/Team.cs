using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoccerRadarAPI.Models
{
    public class Team
    {
        public string id { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string alias { get; set; }
        public string country_code { get; set; }
        public string country { get; set; }
        public string type { get; set; }
        public string reference_id { get; set; }
        public Int16 matches { get; set; }
        public Int16 goals { get; set; }
        public string substituted_in { get; set; }
    }
}
