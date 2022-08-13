using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Services;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payoneer.Controllers
{
    [ApiController]
    [Route("NBAGames")]
    public class NBAGamesController : ControllerBase
    {

        private readonly ILogger<NBAGamesController> _logger;
        private readonly NBAGamesServices _nBAGamesServices;
        public NBAGamesController(ILogger<NBAGamesController> logger, NBAGamesServices nBAGamesServices)
        {
            _nBAGamesServices = nBAGamesServices;
            _logger = logger;
        }

        [HttpGet]
        [Route("Get/{page}")]
        public async Task<IEnumerable<NBAGames>> Get(int page)
        {
            var nbaGames = await _nBAGamesServices.GetNBAGames(page);
            return nbaGames;
        }
    }
}
