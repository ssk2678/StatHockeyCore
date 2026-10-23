using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IPowerPlayInfo
    {
        int SituationTimeRemaining { get; set; }
        int SituationTimeElapsed { get; set; }
        bool InSituation { get; set; }

    }
}
