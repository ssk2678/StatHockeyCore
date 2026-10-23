using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class PowerPlayInfo : IPowerPlayInfo
    {
        [JsonProperty(PropertyName = "situationTimeRemaining")]
        public int SituationTimeRemaining { get; set; }
        [JsonProperty(PropertyName = "situationTimeElapsed")]
        public int SituationTimeElapsed { get; set; }
        [JsonProperty(PropertyName = "inSituation")]
        public bool InSituation { get; set; }
    }
}
