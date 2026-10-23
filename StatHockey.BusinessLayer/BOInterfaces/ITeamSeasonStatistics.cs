using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ITeamSeasonStatistics
    {
       TeamStatType Type { get; set; }
       List<TeamSplit> Splits { get; set; }

    }
}
