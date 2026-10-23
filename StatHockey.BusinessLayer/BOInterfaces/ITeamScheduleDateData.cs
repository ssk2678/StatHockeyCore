using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ITeamScheduleDateData
    {
        DateTime Date { get; set; }
        int TotalItems { get; set; }
        int TotalEvents { get; set; }
        int TotalGames { get; set; }
        int TotalMatches { get; set; }

        List<Game> Games { get; set; }

    }
}
