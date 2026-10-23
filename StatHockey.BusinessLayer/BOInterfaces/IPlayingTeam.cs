using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    public interface IPlayingTeam
    {
        int Goals { get; set; }
        int ShotsOnGoal { get; set; }
        string RinkSide { get; set; }
        int Scores { get; set; }
        int Attempts { get; set; }
        Team Team { get; set; }
        bool GoaliePulled { get; set; }
        int NumSkaters { get; set; }
        bool PowerPlay { get; set; }
    }
}
