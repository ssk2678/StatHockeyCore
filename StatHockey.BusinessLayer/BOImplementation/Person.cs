using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Person : IPerson
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }
        [JsonProperty(PropertyName = "primaryNumber")]
        public int PrimaryNumber { get; set; }        
        [JsonProperty(PropertyName = "birthDate")]        
        public DateTime BirthDate { get; set; }
        [JsonProperty(PropertyName = "currentAge")]
        public int CurrentAge { get; set; }
        [JsonProperty(PropertyName = "birthCity")]
        public string BirthCity { get; set; }
        [JsonProperty(PropertyName = "birthStateProvince")]
        public string BirthStateProvince { get; set; }
        [JsonProperty(PropertyName = "birthCountry")]
        public string BirthCountry { get; set; }
        [JsonProperty(PropertyName = "nationality")]
        public string Nationality { get; set; }
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }
        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }
        [JsonProperty(PropertyName = "alternativeCaptain")]
        public bool AlternativeCaptain { get; set; }
        [JsonProperty(PropertyName = "captain")]
        public bool Captain { get; set; }
        [JsonProperty(PropertyName = "rookie")]
        public bool Rookie { get; set; }
        [JsonProperty(PropertyName = "shootsCatches")]
        public char ShootsCatches { get; set; }
        [JsonProperty(PropertyName = "rosterStatus")]
        public char RosterStatus { get; set; }
        [JsonProperty(PropertyName = "currentTeam")]
        public Team CurrentTeam { get; set; }
        [JsonProperty(PropertyName = "primaryPosition")]
        public Position PrimaryPosition { get; set; }

    }
}
