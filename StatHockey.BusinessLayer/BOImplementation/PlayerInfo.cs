using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class PlayerInfo : IPlayerInfo
    {
        public List<Person> PlayerGeneralInfo { get; set; }
        public List<PlayerSeasonStatistics> PlayerSeasonStats { get; set; }

        public string PlayerImageUrl { get; set; }
    }
}
