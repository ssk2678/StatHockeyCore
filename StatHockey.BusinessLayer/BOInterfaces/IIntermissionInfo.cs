using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IIntermissionInfo
    {
        int IntermissionTimeRemaining { get; set; }
        int IntermissionTimeElapsed { get; set; }
        bool InIntermission { get; set; }
    }
}
