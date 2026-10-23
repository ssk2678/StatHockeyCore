using System;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Web;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.APILayer.APIInterfaces;

namespace StatHockey.APILayer.APIImplementation
{
    public class GameAPI : IGameAPI
    {
        HttpClient client = new HttpClient();

        public GameAPI(IConfiguration configuration)
        {
            client.BaseAddress = new Uri(configuration["StatHockeyCoreConfig:NHLApi"]);
            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Schedule> GetTeamGamesFromDates(int teamId, string teamName, DateTime startDate, DateTime endDate)
        {
            HttpResponseMessage response = await client.GetAsync("api/v1/schedule?teamId=" + teamId + "&startDate=" + startDate.ToString("yyyy-MM-dd") + "&endDate=" + endDate.ToString("yyyy-MM-dd"));
            Schedule teamDatesSchedule = new Schedule();

            if (response.IsSuccessStatusCode)
            {
                teamDatesSchedule = await response.Content.ReadFromJsonAsync<Schedule>();
                teamDatesSchedule.SelectedTeamName = teamName;
                teamDatesSchedule.SelectedTeamLogoName = teamDatesSchedule.SelectedTeamName + ".png";
                teamDatesSchedule.SelectedTeamLogoPath = "images/TeamLogos/NHLTeams/" + teamDatesSchedule.SelectedTeamLogoName;
                //teamDatesSchedule.dates.ForEach(d => d.games.First().gameDate = d.games.First().gameDate.Date);
                //teamDatesSchedule.dates.ForEach(d => d.games.First().teams.away.team.logoName = d.games.First().teams.away.team.name + ".gif");
                //teamDatesSchedule.dates.ForEach(d => d.games.First().teams.away.team.logoPath = "Content/Images/TeamLogos/NHLTeams/" + d.games.First().teams.away.team.logoName);
            }

            return teamDatesSchedule; ;
        }

        public async Task<Game> GetSingleGameStatInfo(int gameId)
        {
            HttpResponseMessage response = await client.GetAsync("api/v1/game/" + gameId + "/linescore");
            Game gameStats = new Game();

            if (response.IsSuccessStatusCode)
            {
                gameStats = await response.Content.ReadFromJsonAsync<Game>();
            }

            return gameStats;
        }
    }
}
