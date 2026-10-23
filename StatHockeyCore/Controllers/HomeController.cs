using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatHockey.APILayer.APIImplementation;
using StatHockey.BusinessLayer.BOImplementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System.Threading.Tasks;

namespace StatHockey.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public ViewResult Index()
        //{
        //    //this.GetAllCurrentTeams();
        //    return View("Index");

        //}

        public ViewResult Index(string selectionOption)
        {
            ViewBag.SelectionOption = selectionOption;
            return View("Index");
        }

        //[HttpGet]
        //public JsonResult GetAllCurrentTeams()
        //{
        //    TeamAPI tapi = new TeamAPI();
        //    League leagueTeams = new League();

        //    leagueTeams = tapi.GetAllTeams();
            
        //    return Json(leagueTeams, JsonRequestBehavior.AllowGet);
        //}

        [HttpGet]
        public async Task<JsonResult> GetTeamGames(int teamId, string teamName, DateTime startDate, DateTime endDate)
        {
            GameAPI gapi = new GameAPI(_configuration);
            Schedule teamScheduledGames = new Schedule();

            teamScheduledGames = await gapi.GetTeamGamesFromDates(teamId, teamName, startDate, endDate);

            return Json(teamScheduledGames, new System.Text.Json.JsonSerializerOptions());

        }

        [HttpGet]
        public async Task<JsonResult> GetAllSeasons()
        {
            CommonAPI capi = new CommonAPI(_configuration);

            LeagueSeason seasons = await capi.GetSeasons();

            return Json(seasons, new System.Text.Json.JsonSerializerOptions());

        }

        [HttpGet]
        public async Task<JsonResult> GetTeamSeasonRoster (int teamId, string seasonId)
        {
            PlayerAPI papi = new PlayerAPI(_configuration);

            TeamSeasonRoster teamSeasonRoster = new TeamSeasonRoster();


            teamSeasonRoster = await papi.GetTeamSeasonRoster(teamId, seasonId);

            return Json(teamSeasonRoster, new System.Text.Json.JsonSerializerOptions());
        }

    }
}