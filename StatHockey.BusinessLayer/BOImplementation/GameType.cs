using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class GameType : IGameType
    {
        [JsonProperty(PropertyName = "id")]
        public string ID { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "postseason")]
        public bool PostSeason { get; set; }
    }
}
