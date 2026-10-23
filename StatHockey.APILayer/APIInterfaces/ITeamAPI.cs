using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using StatHockey.BusinessLayer.BOImplementation;


namespace StatHockey.APILayer.APIInterfaces
{
    interface ITeamAPI
    {
        Task<League> GetAllTeams();
        Task<Team> GetNoLongerExistingTeamById(int teamID);
        Task<Team> GetTeamById(int teamID, string season);
        

    }
}
