using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamSeasonRoster : ITeamSeasonRoster
    {
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }
        [JsonProperty(PropertyName = "roster")]
        public List<TeamRoster> Roster { get; set; }
    }
}
