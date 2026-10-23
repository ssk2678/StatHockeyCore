using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamSplit
    {
        [JsonProperty(PropertyName = "stat")]
        public TeamStat Stat { get; set; }
        //TeamStatRank stat { get; set; }
        [JsonProperty(PropertyName = "team")]
        public Team Team { get; set; }
    }
}
