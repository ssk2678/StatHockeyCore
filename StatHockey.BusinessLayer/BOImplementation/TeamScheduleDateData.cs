using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamScheduleDateData : ITeamScheduleDateData
    {
        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }
        [JsonProperty(PropertyName = "totalItems")]
        public int TotalItems { get; set; }
        [JsonProperty(PropertyName = "totalEvents")]
        public int TotalEvents { get; set; }
        [JsonProperty(PropertyName = "totalGames")]
        public int TotalGames { get; set; }
        [JsonProperty(PropertyName = "totalMatches")]
        public int TotalMatches { get; set; }
        [JsonProperty(PropertyName = "games")]
        public List<Game> Games { get; set; }
    }
}
