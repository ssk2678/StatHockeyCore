using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamSeasonStatistics : ITeamSeasonStatistics
    {
        [JsonProperty(PropertyName = "type")]
        public TeamStatType Type { get; set; }
        [JsonProperty(PropertyName = "splits")]
        public List<TeamSplit> Splits { get; set; }
    }
}
