using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class NBATeam
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("division")]
        public string Division { get; set; }
    }
}
