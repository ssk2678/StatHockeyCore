using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Split : ISplit
    {
        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }
        [JsonProperty(PropertyName = "stat")]
        public PlayerStat Stat { get; set; }
    }
}
