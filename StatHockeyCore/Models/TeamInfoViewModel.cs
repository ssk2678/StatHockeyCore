using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.APILayer.APIImplementation;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Models
{
    public class TeamInfoViewModel
    {
        public TeamInfo TeamInfo;
        private IConfiguration _configuration;

        public TeamInfoViewModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task GetTeamInfo(int teamId, string season)
        {
            TeamAPI tapi = new TeamAPI(_configuration);
            Team team = new Team();
            
            team = await tapi.GetTeamById(teamId, season);
            TeamInfo = new TeamInfo()
            {
                Id = team.Id,
                Name = team.Name,
                Link = team.Link,
                Venue = team.Venue,
                Abbreviation = team.Abbreviation,
                TeamName = team.TeamName,
                LocationName = team.LocationName,
                FirstYearOfPlay = team.FirstYearOfPlay,
                Division = team.Division,
                Conference = team.Conference,
                Franchise = team.Franchise,
                ShortName = team.ShortName,
                OfficialSiteUrl = team.OfficialSiteUrl,
                FranchiseId = team.FranchiseId,
                LogoName = team.LogoName,
                LogoPath = team.LogoPath,
                Active = team.Active,
                Roster = team.Roster,
                SeasonPerformanceStats = team.TeamStats.Single().Splits.First().Stat,
                SeasonRankStats = team.TeamStats.Single().Splits.Last().Stat,
                Season = season.Insert(4, "-")
            };                        
        }
    }

    
}
