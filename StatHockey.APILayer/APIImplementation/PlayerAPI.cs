using System;

using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using StatHockey.APILayer.APIInterfaces;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.APILayer.APIImplementation
{
    public class PlayerAPI : IPlayerAPI
    {
        HttpClient client = new HttpClient();


        public PlayerAPI(IConfiguration configuration)
        {
            client.BaseAddress = new Uri(configuration["StatHockeyCoreConfig:NHLApi"]);
            //Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TeamSeasonRoster> GetTeamSeasonRoster(int teamId, string seasonId)
        {
            TeamSeasonRoster teamSeasonRoster = new TeamSeasonRoster();
            League league = new League();
            HttpResponseMessage response = await client.GetAsync("api/v1/teams/" + teamId + "?" + "expand=team.roster&season=" + seasonId);

            teamSeasonRoster.Roster = new List<TeamRoster>();
            

            if(response.IsSuccessStatusCode)
            {
                //Parse the response body. Blocking
                league = response.Content.ReadFromJsonAsync<League>().Result;
                league.Teams.First().Roster.Season = seasonId;
                teamSeasonRoster = league.Teams.First().Roster;
            }
                       

            return teamSeasonRoster;
        }

        public async Task<PlayerInfo> GetPlayerSingleSeasonStatInfo(int playerId, string seasonId)
        {           

            List<Person> playerGeneralInfo = new List<Person>();
            List<PlayerSeasonStatistics> playerSingleStatSeasonInfo = new List<PlayerSeasonStatistics>();
            PlayerInfo player = new PlayerInfo();

            League firstPlayerInfoTask = await GetGeneralPlayerInfo(playerId);
            League secondPlayerInfoTask = await GetPlayerSingleStatSeasonInfo(playerId, seasonId);

                       
            //firstPlayerInfoTask.Start();
            //secondPlayerInfoTask.Start();                       
          
            playerGeneralInfo = firstPlayerInfoTask.People;
            playerSingleStatSeasonInfo = secondPlayerInfoTask.stats;

            player = new PlayerInfo { PlayerGeneralInfo = playerGeneralInfo, PlayerSeasonStats = playerSingleStatSeasonInfo };          

            return player;
        }

        public async Task<League> GetGeneralPlayerInfo(int playerId)
        {
            HttpResponseMessage playerGeneralInfoResponse = new HttpResponseMessage();
            League playerGeneralInfo = null;

             //Task.Run(() => {

                playerGeneralInfoResponse = await client.GetAsync("api/v1/people/" + playerId);
                if (playerGeneralInfoResponse.IsSuccessStatusCode)
                {
                    playerGeneralInfo = await playerGeneralInfoResponse.Content.ReadFromJsonAsync<League>();
                }
            //});

            return playerGeneralInfo;
        }

        public async Task<League> GetPlayerSingleStatSeasonInfo (int playerId, string seasonId)
        {
            HttpResponseMessage playerSingleStatSeasonInfoResponse = new HttpResponseMessage();
            League playerSingleStatSeasonInfo = null;

            //Task.Run(() => {

                playerSingleStatSeasonInfoResponse = await client .GetAsync("api/v1/people/" + playerId + "/stats?stats=statsSingleSeason&season=" + seasonId);                   
                if (playerSingleStatSeasonInfoResponse.IsSuccessStatusCode)
                {
                    playerSingleStatSeasonInfo = await playerSingleStatSeasonInfoResponse.Content.ReadFromJsonAsync<League>();

                }

            //});            

            return playerSingleStatSeasonInfo;
        }
    }
}
