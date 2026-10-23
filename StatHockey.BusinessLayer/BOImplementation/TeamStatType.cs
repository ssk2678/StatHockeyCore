using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamStatType : ITeamStatType
    {
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        [JsonProperty(PropertyName = "gameType")]
        public GameType GameType { get; set; }
    }
}
