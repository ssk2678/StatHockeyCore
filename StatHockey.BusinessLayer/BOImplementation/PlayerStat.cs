using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class PlayerStat : IStat
    {
        [JsonProperty(PropertyName = "timeOnIce")]
        [DisplayName("Time On Ice")]
        public string TimeOnIce { get; set; }

        [JsonProperty(PropertyName = "assists")]
        [DisplayName("Assists")]
        public int Assists { get; set; }

        [JsonProperty(PropertyName = "goals")]
        [DisplayName("Goals")]
        public int Goals { get; set; }

        [JsonProperty(PropertyName = "pim")]
        [DisplayName("Pim")]
        public int Pim { get; set; }

        [JsonProperty(PropertyName = "shots")]
        [DisplayName("Shots")]
        public int Shots { get; set; }

        [JsonProperty(PropertyName = "games")]
        [DisplayName("Games")]
        public int Games { get; set; }

        [JsonProperty(PropertyName = "hits")]
        [DisplayName("Hits")]
        public int Hits { get; set; }

        [JsonProperty(PropertyName = "powerPlayGoals")]
        [DisplayName("Power Play Goals")]
        public int PowerPlayGoals { get; set; }

        [JsonProperty(PropertyName = "powerPlayPoints")]
        [DisplayName("Power Play Points")]
        public int PowerPlayPoints { get; set; }

        [JsonProperty(PropertyName = "powerPlayTimeOnIce")]
        [DisplayName("Power Play Time On Ice")]
        public string PowerPlayTimeOnIce { get; set; }

        [JsonProperty(PropertyName = "evenTimeOnIce")]
        [DisplayName("Even Time On Ice")]
        public string EvenTimeOnIce { get; set; }

        [JsonProperty(PropertyName = "penaltyMinutes")]
        [DisplayName("Penalty Minutes")]
        public int PenaltyMinutes { get; set; }

        [JsonProperty(PropertyName = "faceOffPct")]
        [DisplayName("Face Off Percent")]
        public float FaceOffPct { get; set; }

        [JsonProperty(PropertyName = "shotPct")]
        [DisplayName("Shot Percent")]
        public float ShotPct { get; set; }

        [JsonProperty(PropertyName = "gameWinningGoals")]
        [DisplayName("Game Winning Goals")]
        public int GameWinningGoals { get; set; }

        [JsonProperty(PropertyName = "overTimeGoals")]
        [DisplayName("Over Time Goals")]
        public int OverTimeGoals { get; set; }

        [JsonProperty(PropertyName = "shortHandedGoals")]
        [DisplayName("Short Handed Goals")]
        public int ShortHandedGoals { get; set; }

        [JsonProperty(PropertyName = "shortHandedPoints")]
        [DisplayName("Short Handed Points")]
        public int ShortHandedPoints { get; set; }

        [JsonProperty(PropertyName = "shortHandedTimeOnIce")]
        [DisplayName("Short Handed Time On Ice")]
        public string ShortHandedTimeOnIce { get; set; }

        [JsonProperty(PropertyName = "blocked")]
        [DisplayName("Blocked")]
        public int Blocked { get; set; }

        [JsonProperty(PropertyName = "plusMinus")]
        [DisplayName("Plus Minus")]
        public int PlusMinus { get; set; }

        [JsonProperty(PropertyName = "points")]
        [DisplayName("Points")]
        public int Points { get; set; }

        [JsonProperty(PropertyName = "shifts")]
        [DisplayName("Shifts")]
        public int Shifts { get; set; }

        [JsonProperty(PropertyName = "timeOnIcePerGame")]
        [DisplayName("Time On Ice Per Game")]
        public string TimeOnIcePerGame { get; set; }

        [JsonProperty(PropertyName = "evenTimeOnIcePerGame")]
        [DisplayName("Even Time On Ice Per Game")]
        public string EvenTimeOnIcePerGame { get; set; }

        [JsonProperty(PropertyName = "shortHandedTimeOnIcePerGame")]
        [DisplayName("Short Handed Time On Ice Per Game")]
        public string ShortHandedTimeOnIcePerGame { get; set; }

        [JsonProperty(PropertyName = "powerPlayTimeOnIcePerGame")]
        [DisplayName("Power Play Time On Ice Per Game")]
        public string PowerPlayTimeOnIcePerGame { get; set; }
    }
}
