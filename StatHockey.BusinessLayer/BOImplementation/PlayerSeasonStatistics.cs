using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class PlayerSeasonStatistics : IPlayerSeasonStatistics
    {
        [JsonProperty(PropertyName = "type")]
        public PlayerStatType Type { get; set; }
        [JsonProperty(PropertyName = "splits")]
        public List<Split> Splits { get; set; }
    }
}
