using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamStatRank : ITeamStatRank
    {
        [JsonProperty(PropertyName = "wins")]
        public string Wins { get; set; }
        [JsonProperty(PropertyName = "losses")]
        public string Losses { get; set; }
        [JsonProperty(PropertyName = "ot")]
        public string OT { get; set; }
        [JsonProperty(PropertyName = "pts")]
        public string Pts { get; set; }
        [JsonProperty(PropertyName = "ptPctg")]
        public string PtPctg { get; set; }
        [JsonProperty(PropertyName = "goalsPerGame")]
        public string GoalsPerGame { get; set; }
        [JsonProperty(PropertyName = "goalsAgainstPerGame")]
        public string GoalsAgainstPerGame { get; set; }
        [JsonProperty(PropertyName = "evGGARatio")]
        public string EVGGARatio { get; set; }
        [JsonProperty(PropertyName = "powerPlayPercentage")]
        public string PowerPlayPercentage { get; set; }
        [JsonProperty(PropertyName = "powerPlayGoals")]
        public string PowerPlayGoals { get; set; }
        [JsonProperty(PropertyName = "powerPlayGoalsAgainst")]
        public string PowerPlayGoalsAgainst { get; set; }
        [JsonProperty(PropertyName = "powerPlayOpportunities")]
        public string PowerPlayOpportunities { get; set; }
        [JsonProperty(PropertyName = "penaltyKillOpportunities")]
        public string PenaltyKillOpportunities { get; set; }
        [JsonProperty(PropertyName = "penaltyKillPercentage")]
        public string PenaltyKillPercentage { get; set; }
        [JsonProperty(PropertyName = "shotsPerGame")]
        public string ShotsPerGame { get; set; }
        [JsonProperty(PropertyName = "shotsAllowed")]
        public string ShotsAllowed { get; set; }
        [JsonProperty(PropertyName = "winScoreFirst")]
        public string WinScoreFirst { get; set; }
        [JsonProperty(PropertyName = "winOppScoreFirst")]
        public string WinOppScoreFirst { get; set; }
        [JsonProperty(PropertyName = "winLeadFirstPer")]
        public string WinLeadFirstPer { get; set; }
        [JsonProperty(PropertyName = "winLeadSecondPer")]
        public string WinLeadSecondPer { get; set; }
        [JsonProperty(PropertyName = "winOutshootOpp")]
        public string WinOutshootOpp { get; set; }
        [JsonProperty(PropertyName = "winOutshotByOpp")]
        public string WinOutshotByOpp { get; set; }
        [JsonProperty(PropertyName = "faceOffsTaken")]
        public string FaceOffsTaken { get; set; }
        [JsonProperty(PropertyName = "faceOffsWon")]
        public string FaceOffsWon { get; set; }
        [JsonProperty(PropertyName = "faceOffsLost")]
        public string FaceOffsLost { get; set; }
        [JsonProperty(PropertyName = "faceOffWinPercentage")]
        public string FaceOffWinPercentage { get; set; }
        [JsonProperty(PropertyName = "savePctRank")]
        public string SavePctRank { get; set; }
        [JsonProperty(PropertyName = "shootingPctRank")]
        public string ShootingPctRank { get; set; }
    }
}
