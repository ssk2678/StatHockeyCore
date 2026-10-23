using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.APILayer.APIInterfaces;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace StatHockey.APILayer.APIImplementation
{
    public class TeamAPI : ITeamAPI
    {
        HttpClient client = new HttpClient();
        private IConfiguration _configuration;

        public TeamAPI (IConfiguration configuration)
        {
            _configuration = configuration;

            client.BaseAddress = new Uri(configuration["StatHockeyCoreConfig:NHLApi"]);
            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }        

        public async Task<League> GetAllTeams()
        {
            HttpResponseMessage response = await client.GetAsync("api/v1/teams") ;    // Blocking call!
            League hockeyTeamList = new League();

            if (response.IsSuccessStatusCode)
            {
                //Parse the response body. Blocking!
                hockeyTeamList = await response.Content.ReadFromJsonAsync<League>();

                hockeyTeamList.Teams[7].Name = RemoveDiacritics(hockeyTeamList.Teams[7].Name);
                hockeyTeamList.Teams.ForEach(t => t.LogoName = t.Name + ".png");
                hockeyTeamList.Teams.ForEach(t => t.LogoPath = "../images/TeamLogos/NHLTeams/" + t.LogoName);

                List<Team> teamListOrdered = hockeyTeamList.Teams.OrderBy(team => team.Name).ToList();
                hockeyTeamList.Teams = teamListOrdered;

            }
            return hockeyTeamList;
                        
        }

        public async Task<Team> GetTeamById(int teamID, string season)
        {           

            HttpResponseMessage response = await client.GetAsync("api/v1/teams/" + teamID + "?expand=team.stats&season=" + season);    // Blocking call!
            League hockeyTeamList = new League();
                       
            Team hockeyTeam = new Team();

            if (response.IsSuccessStatusCode)
            {
                hockeyTeamList = await response.Content.ReadFromJsonAsync<League>();
                hockeyTeam = hockeyTeamList.Teams.First();
                hockeyTeam.LogoName = hockeyTeam.Name + ".png";
                hockeyTeam.LogoPath = "../images/TeamLogos/NHLTeams/" + hockeyTeam.LogoName;               
                
                PlayerAPI papi = new PlayerAPI(_configuration);
                TeamSeasonRoster seasonRoster = new TeamSeasonRoster();
                seasonRoster = await papi.GetTeamSeasonRoster(teamID, season);

                hockeyTeam.Roster = seasonRoster;

            }

            return hockeyTeam;
        }       

        public async Task<Team> GetNoLongerExistingTeamById(int teamID)
        {
            Team hockeyTeam = new Team();
            HttpResponseMessage response = await client.GetAsync("api/league/GetSingleLeagueTeam" + "?teamID=" + teamID.ToString());

            if (response.IsSuccessStatusCode)
            {
                hockeyTeam = await response.Content.ReadFromJsonAsync<Team>();
            }

            return hockeyTeam;

        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}