using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.APILayer.APIInterfaces
{
    interface IGameAPI
    {
        Task<Schedule> GetTeamGamesFromDates(int teamId, string teamName, DateTime startDate, DateTime endDate);

        Task<Game> GetSingleGameStatInfo(int gameId);

    }
}
