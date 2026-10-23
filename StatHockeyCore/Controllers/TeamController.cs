using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using StatHockey.APILayer.APIImplementation;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Controllers
{
    public class TeamController : Controller
    {

        private IConfiguration _configuration;
        public TeamController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: Team
        public ActionResult Index()
        {
            TeamInfoViewModel tivModel = new TeamInfoViewModel(_configuration);
            return View("TeamDetailView", tivModel);
        }

        //[HttpGet]
        //public JsonResult GetAllCurrentTeams()
        //{
        //    TeamAPI tapi = new TeamAPI();
        //    League leagueTeams = new League();

        //    leagueTeams = tapi.GetAllTeams();

        //    return Json(leagueTeams, JsonRequestBehavior.AllowGet);
        //}

        public async Task<ViewResult> GetTeamData(int teamId, string season)
        {
            TeamInfoViewModel tivm = new TeamInfoViewModel(_configuration);

            if (String.IsNullOrEmpty(season) || season == "0")
            {
                CommonAPI capi = new CommonAPI(_configuration);
                LeagueSeason lsList = await capi.GetSeasons();
                season = lsList.Seasons.Last().SeasonId;
            }

            await tivm.GetTeamInfo(teamId, season);

            return View("TeamDetailView", tivm);

        }
    }
}