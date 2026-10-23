using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ITeamStatRank
    {
        string Wins { get; set; }
        string Losses { get; set; }
        string OT { get; set; }
        string Pts { get; set; }
        string PtPctg { get; set; }
        string GoalsPerGame { get; set; }
        string GoalsAgainstPerGame { get; set; }
        string EVGGARatio { get; set; }
        string PowerPlayPercentage { get; set; }
        string PowerPlayGoals { get; set; }
        string PowerPlayGoalsAgainst { get; set; }
        string PowerPlayOpportunities { get; set; }
        string PenaltyKillOpportunities { get; set; }
        string PenaltyKillPercentage { get; set; }
        string ShotsPerGame { get; set; }
        string ShotsAllowed { get; set; }
        string WinScoreFirst { get; set; }
        string WinOppScoreFirst { get; set; }
        string WinLeadFirstPer { get; set; }
        string WinLeadSecondPer { get; set; }
        string WinOutshootOpp { get; set; }
        string WinOutshotByOpp { get; set; }
        string FaceOffsTaken { get; set; }
        string FaceOffsWon { get; set; }
        string FaceOffsLost { get; set; }
        string FaceOffWinPercentage { get; set; }
        string SavePctRank { get; set; }
        string ShootingPctRank { get; set; }
    }
}
