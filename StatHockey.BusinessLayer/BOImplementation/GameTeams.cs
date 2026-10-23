using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class GameTeams : IGameTeams
    {
        [JsonProperty(PropertyName = "away")]
        public PlayingTeam Away { get; set; }
        [JsonProperty(PropertyName = "home")]
        public PlayingTeam Home { get; set; }
    }
}
