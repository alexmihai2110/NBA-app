using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Services
{
    public class NBAGamesServices
    {
        private HttpClient client;
        public NBAGamesServices()
        {
            client = new HttpClient();
        }

        public async Task<IEnumerable<NBAGames>> GetNBAGames(int page)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://free-nba.p.rapidapi.com/games?page={page}&per_page=25"),
                Headers =
                {
                        { "X-RapidAPI-Key", "de882099a8mshc7856e83b2e4344p14efecjsncce87d81230c" },
                        { "X-RapidAPI-Host", "free-nba.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var deserializedBody = (JObject)JsonConvert.DeserializeObject(body);
                var nBAGames = deserializedBody.SelectToken("data").ToObject<IEnumerable<NBAGames>>();
                return nBAGames;
            }

        }
    }
}
