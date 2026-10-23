using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.APILayer.APIImplementation;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Models
{
    public class GameInfoViewModel
    {
        public GameInfo GameInfo;
        private IConfiguration _configuration;

        public GameInfoViewModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task GetGameInfo (int gameId)
        {
            GameAPI gapi = new GameAPI(_configuration);
            GameInfo = new GameInfo();
            Game game = new Game();

            game = await gapi.GetSingleGameStatInfo(gameId);

            GameInfo.Game = game;
        }
    }
}
