using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class PlayingTeam : IPlayingTeam
    {
        [JsonProperty(PropertyName = "goals")]
        public int Goals { get; set; }
        [JsonProperty(PropertyName = "shotsOnGoal")]
        public int ShotsOnGoal { get; set; }
        [JsonProperty(PropertyName = "rinkSide")]
        public string RinkSide { get; set; }
        [JsonProperty(PropertyName = "scores")]
        public int Scores { get; set; }
        [JsonProperty(PropertyName = "attempts")]
        public int Attempts { get; set; }
        [JsonProperty(PropertyName = "team")]
        public Team Team { get; set; }
        [JsonProperty(PropertyName = "goaliePulled")]
        public bool GoaliePulled { get; set; }
        [JsonProperty(PropertyName = "numSkaters")]
        public int NumSkaters { get; set; }
        [JsonProperty(PropertyName = "powerPlay")]
        public bool PowerPlay { get; set; }
    }
}
