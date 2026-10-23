using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Schedule : ISchedule
    {
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }
        [JsonProperty(PropertyName = "totalItems")]
        public int TotalItems { get; set; }
        [JsonProperty(PropertyName = "totalEvents")]
        public int TotalEvents { get; set; }
        [JsonProperty(PropertyName = "totalMatches")]
        public int TotalMatches { get; set; }
        [JsonProperty(PropertyName = "wait")]
        public int Wait { get; set; }
        [JsonProperty(PropertyName = "selectedTeamName")]
        public string SelectedTeamName { get; set; }
        [JsonProperty(PropertyName = "selectedTeamLogoName")]
        public string SelectedTeamLogoName { get; set; }
        [JsonProperty(PropertyName = "selectedTeamLogoPath")]
        public string SelectedTeamLogoPath { get; set; }
        [JsonProperty(PropertyName = "dates")]
        public List<TeamScheduleDateData> Dates { get; set; }
        

    }
}
