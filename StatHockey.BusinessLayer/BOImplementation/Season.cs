using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Season : ISeason
    {
        [JsonProperty(PropertyName = "seasonId")]
        public string SeasonId { get; set; }
        [JsonProperty(PropertyName = "regularSeasonStartDate")]
        public DateTime RegularSeasonStartDate { get; set; }
        [JsonProperty(PropertyName = "regularSeasonEndDate")]
        public DateTime RegularSeasonEndDate { get; set; }
        [JsonProperty(PropertyName = "numberOfGames")]
        public int NumberOfGames { get; set; }
        [JsonProperty(PropertyName = "tiesInUse")]
        public bool TiesInUse { get; set; }
        [JsonProperty(PropertyName = "olympicsParticipation")]
        public bool OlympicsParticipation { get; set; }
        [JsonProperty(PropertyName = "conferencesInUse")]
        public bool ConferencesInUse { get; set; }
        [JsonProperty(PropertyName = "divisionsInUse")]
        public bool DivisionsInUse { get; set; }
        [JsonProperty(PropertyName = "wildCardInUse")]
        public bool WildCardInUse { get; set; }
    }
}
