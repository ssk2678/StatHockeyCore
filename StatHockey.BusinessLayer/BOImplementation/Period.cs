using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Period : IPeriod
    {
        [JsonProperty(PropertyName = "periodType")]
        public string PeriodType { get; set; }
        [JsonProperty(PropertyName = "startTime")]
        public DateTime StartTime { get; set; }
        [JsonProperty(PropertyName = "endTime")]
        public DateTime EndTime { get; set; }
        [JsonProperty(PropertyName = "num")]
        public int Num { get; set; }
        [JsonProperty(PropertyName = "ordinalNum")]
        public string OrdinalNum { get; set; }
        [JsonProperty(PropertyName = "home")]
        public PlayingTeam Home { get; set; }
        [JsonProperty(PropertyName = "away")]
        public PlayingTeam Away { get; set; }
        
    }
}
