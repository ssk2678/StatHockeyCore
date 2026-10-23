using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using StatHockey.APILayer.APIImplementation;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Controllers
{
    public class PlayerController : Controller
    {

        private IConfiguration _configuration;
        public PlayerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: Player
        public ActionResult Index()
        {
            PlayerInfoViewModel pivModel = new PlayerInfoViewModel(_configuration);
            return View("PlayerDetailView", pivModel);
        }

        public async Task<ViewResult> GetPlayerData(int playerId, string seasonId)
        {
            PlayerInfoViewModel pivm = new PlayerInfoViewModel(_configuration);
          
            await pivm.GetPlayerInfo(playerId, seasonId);

            return View("PlayerDetailView", pivm);

        }
    }
}