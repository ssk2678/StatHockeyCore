using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IPlayerInfo
    {
        List<Person> PlayerGeneralInfo { get; set; }
        List<PlayerSeasonStatistics> PlayerSeasonStats { get; set; }

    }
}
