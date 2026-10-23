using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class League : ILeague
    {
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }
        [JsonProperty(PropertyName = "teams")]
        public List<Team> Teams { get; set; }
        [JsonProperty(PropertyName = "people")]
        public List<Person> People { get; set; }
        public List<PlayerSeasonStatistics> stats { get; set; }
    }
}
