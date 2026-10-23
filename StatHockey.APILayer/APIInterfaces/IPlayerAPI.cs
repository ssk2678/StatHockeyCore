using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.APILayer.APIInterfaces
{
    interface IPlayerAPI
    {
        Task<TeamSeasonRoster> GetTeamSeasonRoster(int teamId, string seasonId);
        Task<PlayerInfo> GetPlayerSingleSeasonStatInfo(int playerId, string seasonId);

        Task<League> GetGeneralPlayerInfo(int playerId);

        Task<League> GetPlayerSingleStatSeasonInfo(int playerId, string seasonId);
    }
}
