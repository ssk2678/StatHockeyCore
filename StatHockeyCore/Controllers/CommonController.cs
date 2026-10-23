using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using StatHockey.APILayer.APIImplementation;
using StatHockey.BusinessLayer.BOImplementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Controllers
{
    public class CommonController : Controller
    {

        private IConfiguration _configuration;
        public CommonController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<JsonResult> GetAllCurrentTeams()
        {
            TeamAPI tapi = new TeamAPI(_configuration);
            League leagueTeams = new League();

            leagueTeams = await tapi.GetAllTeams();

            return Json(leagueTeams, new System.Text.Json.JsonSerializerOptions());
        }
    }
}