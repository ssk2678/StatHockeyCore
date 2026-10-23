using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StatHockey.APILayer;
using StatHockey.BusinessLayer.BOImplementation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;



namespace StatHockey.Controllers
{    
    public class LeagueController : Controller
    {
        private IConfiguration _configuration;
        public LeagueController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: Team
        public ActionResult Index()
        {
            //TeamAPI tapi = new TeamAPI();
            League teams = new League();
        
            //teams = tapi.GetAllTeams();

            return View();
        }        
        
    }
}