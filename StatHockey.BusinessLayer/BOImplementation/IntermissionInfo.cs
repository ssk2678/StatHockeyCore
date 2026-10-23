using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class IntermissionInfo : IIntermissionInfo
    {
        [JsonProperty(PropertyName = "intermissionTimeRemaining")]
        public int IntermissionTimeRemaining { get; set; }
        [JsonProperty(PropertyName = "intermissionTimeElapsed")]
        public int IntermissionTimeElapsed { get; set; }
        [JsonProperty(PropertyName = "inIntermission")]
        public bool InIntermission { get; set; }
    }
}
