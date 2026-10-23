using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class TeamStat : ITeamStat
    {
        [JsonProperty(PropertyName = "gamesPlayed")]
        [DisplayName("Games Played")]
        public int GamesPlayed { get; set; } 
        
        [JsonProperty(PropertyName = "wins")]
        [DisplayName("Wins")]        
        public string Wins { get; set; }

        [JsonProperty(PropertyName = "losses")]
        [DisplayName("Losses")]
        public string Losses { get; set; }

        [JsonProperty(PropertyName = "ot")]
        [DisplayName("OT")]
        public string OT { get; set; }

        [JsonProperty(PropertyName = "pts")]
        [DisplayName("Points")]
        public string Pts { get; set; }

        [JsonProperty(PropertyName = "ptPctg")]
        [DisplayName("Point Percentage")]
        public string PtPctg { get; set; }

        [JsonProperty(PropertyName = "goalsPerGame")]
        [DisplayName("Goals Per Game")]
        public string GoalsPerGame { get; set; }

        [JsonProperty(PropertyName = "goalsAgainstPerGame")]
        [DisplayName("Goals Against Per Game")]
        public string GoalsAgainstPerGame { get; set; }

        [JsonProperty(PropertyName = "evGGARatio")]
        [DisplayName("EVGGA Ratio")]
        public string EVGGARatio { get; set; }

        [JsonProperty(PropertyName = "powerPlayPercentage")]
        [DisplayName("Power Play Percentage")]
        public string PowerPlayPercentage { get; set; }

        [JsonProperty(PropertyName = "powerPlayGoals")]
        [DisplayName("Power Play Goals")]
        public string PowerPlayGoals { get; set; }

        [JsonProperty(PropertyName = "powerPlayGoalsAgainst")]
        [DisplayName("Power Play Goals Against")]
        public string PowerPlayGoalsAgainst { get; set; }

        [JsonProperty(PropertyName = "powerPlayOpportunities")]
        [DisplayName("Power Play Opportunities")]
        public string PowerPlayOpportunities { get; set; }

        [JsonProperty(PropertyName = "penaltyKillOpportunities")]
        [DisplayName("Penalty Kill Opportunities")]
        public string PenaltyKillOpportunities { get; set; }

        [JsonProperty(PropertyName = "penaltyKillPercentage")]
        [DisplayName("Penalty Kill Percentage")]
        public string PenaltyKillPercentage { get; set; }

        [JsonProperty(PropertyName = "shotsPerGame")]
        [DisplayName("Shots Per Game")]
        public string ShotsPerGame { get; set; }

        [JsonProperty(PropertyName = "shotsAllowed")]
        [DisplayName("Shots Allowed")]
        public string ShotsAllowed { get; set; }

        [JsonProperty(PropertyName = "winScoreFirst")]
        [DisplayName("Win Score First")]
        public string WinScoreFirst { get; set; }

        [JsonProperty(PropertyName = "winOppScoreFirst")]
        [DisplayName("Win Opp Score First")]
        public string WinOppScoreFirst { get; set; }

        [JsonProperty(PropertyName = "winLeadFirstPer")]
        [DisplayName("Win Lead First Percent")]
        public string WinLeadFirstPer { get; set; }

        [JsonProperty(PropertyName = "winLeadSecondPer")]
        [DisplayName("Win Lead Second Perentage")]
        public string WinLeadSecondPer { get; set; }

        [JsonProperty(PropertyName = "winOutshootOpp")]
        [DisplayName("Win Out Shoot Opp")]
        public string WinOutshootOpp { get; set; }

        [JsonProperty(PropertyName = "winOutshotByOpp")]
        [DisplayName("Win Out Shot By Opp")]
        public string WinOutshotByOpp { get; set; }

        [JsonProperty(PropertyName = "faceOffsTaken")]
        [DisplayName("Face Offs Taken")]
        public string FaceOffsTaken { get; set; }

        [JsonProperty(PropertyName = "faceOffsWon")]
        [DisplayName("Face Offs Won")]
        public string FaceOffsWon { get; set; }

        [JsonProperty(PropertyName = "faceOffsLost")]
        [DisplayName("Face Offs Lost")]
        public string FaceOffsLost { get; set; }

        [JsonProperty(PropertyName = "faceOffWinPercentage")]
        [DisplayName("Face Off Win Percentage")]
        public string FaceOffWinPercentage { get; set; }

        [JsonProperty(PropertyName = "shootingPctg")]
        [DisplayName("Shooting Percentage")]
        public string ShootingPctg { get; set; }

        [JsonProperty(PropertyName = "savePctg")]
        [DisplayName("Save Percentage")]
        public string SavePctg { get; set; }

        [JsonProperty(PropertyName = "savePctRank")]
        [DisplayName("Save Percent Rank")]
        public string SavePctRank { get; set; }

        [JsonProperty(PropertyName = "shootingPctRank")]
        [DisplayName("Shooting Percent Rank")]
        public string ShootingPctRank { get; set; }

    }
}
