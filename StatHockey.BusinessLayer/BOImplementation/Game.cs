using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Game : IGame
    {
        [JsonProperty(PropertyName = "copyright")]
        public string Copyright { get; set; }

        [JsonProperty(PropertyName = "currentPeriod")]
        public int CurrentPeriod { get; set; }

        [JsonProperty(PropertyName = "currentPeriodOrdinal")]
        public string CurrentPeriodOrdinal { get; set; }

        [JsonProperty(PropertyName = "currentPeriodTimeRemaining")]
        public string CurrentPeriodTimeRemaining { get; set; }

        [JsonProperty(PropertyName = "periods")]
        public List<Period> periods { get; set; }

        [JsonProperty(PropertyName = "gamePk")]
        public string GamePk { get; set; }

        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

        [JsonProperty(PropertyName = "gameType")]
        public string GameType { get; set; }

        [JsonProperty(PropertyName = "season")]
        public string Season { get; set; }

        [JsonProperty(PropertyName = "gameDate")]
        public DateTime GameDate { get; set; }

        [JsonProperty(PropertyName = "shootoutInfo")]
        public ShootoutInfo ShootoutInfo { get; set; }

        [JsonProperty(PropertyName = "teams")]
        public GameTeams Teams { get; set; }

        [JsonProperty(PropertyName = "powerPlayStrength")]
        public string PowerPlayStrength { get; set; }

        [JsonProperty(PropertyName = "hasShootout")]
        public bool HasShootout { get; set; }

        [JsonProperty(PropertyName = "intermissionInfo")]
        public IntermissionInfo IntermissionInfo { get; set; }

        [JsonProperty(PropertyName = "powerPlayinfo")]
        public PowerPlayInfo PowerPlayInfo { get; set; }

        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }
        
    }
}
