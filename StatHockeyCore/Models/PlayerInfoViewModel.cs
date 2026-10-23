using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.APILayer.APIImplementation;
using Microsoft.Extensions.Configuration;

namespace StatHockey.Models
{
    public class PlayerInfoViewModel
    {
        public PlayerInfo PlayerInfo;
        private IConfiguration _configuration;

        public PlayerInfoViewModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task GetPlayerInfo(int playerId, string seasonId)
        {
            PlayerAPI papi = new PlayerAPI(_configuration);

            PlayerInfo = await papi.GetPlayerSingleSeasonStatInfo(playerId, seasonId);

            PlayerInfo.PlayerSeasonStats[0].Splits[0].Season = PlayerInfo.PlayerSeasonStats[0].Splits[0].Season.Insert(4, "-");

            PlayerInfo.PlayerImageUrl = $"{_configuration["StatHockeyCoreConfig:NHLPlayerImageUrl"]}{playerId}" + ".jpg";

            //PlayerInfo = new PlayerInfo()
            //{
            //    Id = playerInfo.id,
            //    FullName = playerInfo.fullName,
            //    Link = playerInfo.link,
            //    FirstName = playerInfo.firstName,
            //    LastName = playerInfo.lastName,
            //    PrimaryNumber = playerInfo.primaryNumber,
            //    BirthDate = playerInfo.birthDate,
            //    BirthCity = playerInfo.birthCity,
            //    BirthStateProvince = playerInfo.birthStateProvince,
            //    BirthCountry = playerInfo.birthCountry,
            //    Nationality = playerInfo.nationality,
            //    Height = playerInfo.height,
            //    Weight = playerInfo.weight,
            //    Active = playerInfo.active,
            //    Rookie = playerInfo.rookie,
            //    ShootsCatches = playerInfo.shootsCatches,
            //    RosterStatus = playerInfo.rosterStatus,
            //    PrimaryPosition = playerInfo.primaryPosition
            //};

        }
    }

    //public class PlayerInfo
    //{
    //    public string Id { get; set; }
    //    public string FullName { get; set; }
    //    public string Link { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int PrimaryNumber { get; set; }
    //    public DateTime BirthDate { get; set; }
    //    public int CurrentAge { get; set; }
    //    public string BirthCity { get; set; }
    //    public string BirthStateProvince { get; set; }
    //    public string BirthCountry { get; set; }
    //    public string Nationality { get; set; }
    //    public string Height { get; set; }
    //    public int Weight { get; set; }
    //    public bool Active { get; set; }
    //    public bool AlternativeCaptain { get; set; }
    //    public bool Captain { get; set; }
    //    public bool Rookie { get; set; }
    //    public char ShootsCatches { get; set; }
    //    public char RosterStatus { get; set; }
    //    public Team CurrentTeam { get; set; }
    //    public Position PrimaryPosition { get; set; }
    //}
}