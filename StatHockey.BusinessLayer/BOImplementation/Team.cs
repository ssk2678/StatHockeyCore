using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Team : ITeam
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }
        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty(PropertyName = "teamName")]
        public string TeamName { get; set; }
        [JsonProperty(PropertyName = "locationName")]
        public string LocationName { get; set; }
        [JsonProperty(PropertyName = "firstYearOfPlay")]
        public string FirstYearOfPlay { get; set; }
        [JsonProperty(PropertyName = "division")]
        public Division Division { get; set; }
        [JsonProperty(PropertyName = "conference")]
        public Conference Conference { get; set; }
        [JsonProperty(PropertyName = "franchise")]
        public Franchise Franchise { get; set; }
        [JsonProperty(PropertyName = "shortName")]
        public string ShortName { get; set; }
        [JsonProperty(PropertyName = "officialSiteUrl")]
        public string OfficialSiteUrl { get; set; }
        [JsonProperty(PropertyName = "franchiseId")]
        public int FranchiseId { get; set; }
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
        public string LogoName { get; set; }
        public string LogoPath { get; set; }
        
        public TeamSeasonRoster Roster { get; set; }
        [JsonProperty(PropertyName = "teamStats")]
        public List<TeamSeasonStatistics> TeamStats { get; set; }

    }
    
}

