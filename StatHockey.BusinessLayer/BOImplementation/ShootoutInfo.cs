using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;


namespace StatHockey.BusinessLayer.BOImplementation
{
    public class ShootoutInfo : IShootoutInfo
    {
        [JsonProperty(PropertyName = "home")]
        public PlayingTeam Home { get; set; }
        [JsonProperty(PropertyName = "away")]
        public PlayingTeam Away { get; set; }
    }
}
