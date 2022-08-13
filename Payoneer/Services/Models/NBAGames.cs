using Newtonsoft.Json;
using Services.Models;
using System;

namespace Services.Models
{
    public class NBAGames
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("home_team")]
        public NBATeam HomeTeam { get; set; }


        [JsonProperty("home_team_score")]
        public int HomeTeamScore { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("visitor_team")]
        public NBATeam VisitorTeam { get; set; }

        [JsonProperty("visitor_team_score")]
        public int VisitorTeamScore { get; set; }
    }
}
