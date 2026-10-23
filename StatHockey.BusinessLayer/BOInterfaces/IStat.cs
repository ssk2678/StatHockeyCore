using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IStat
    {
        string TimeOnIce { get; set; }
        int Assists { get; set; }
        int Goals { get; set; }
        int Pim { get; set; }
        int Shots { get; set; }
        int Games { get; set; }
        int Hits { get; set; }
        int PowerPlayGoals { get; set; }
        int PowerPlayPoints { get; set; }
        string PowerPlayTimeOnIce { get; set; }
        string EvenTimeOnIce { get; set; }
        int PenaltyMinutes { get; set; }
        float FaceOffPct { get; set; }
        float ShotPct { get; set; }
        int GameWinningGoals { get; set; }
        int OverTimeGoals { get; set; }
        int ShortHandedGoals { get; set; }
        int ShortHandedPoints { get; set; }
        string ShortHandedTimeOnIce { get; set; }
        int Blocked { get; set; }
        int PlusMinus { get; set; }
        int Points { get; set; }
        int Shifts { get; set; }
        string TimeOnIcePerGame { get; set; }
        string EvenTimeOnIcePerGame { get; set; }
        string ShortHandedTimeOnIcePerGame { get; set; }
        string PowerPlayTimeOnIcePerGame { get; set; }

    }
}
