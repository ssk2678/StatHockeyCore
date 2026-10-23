using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StatHockey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Controllers
{
    public class GameController : Controller
    {
        private IConfiguration _configuration;
        public GameController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: Game
        public ActionResult Index()
        {
            return View("GameDetailView");
        }

        public async Task<ViewResult> GetGameInfo(int gameId)
        {
             GameInfoViewModel givm = new GameInfoViewModel(_configuration);

            await givm.GetGameInfo(gameId);

            return View("GameDetailView", givm);

        }
    }
}