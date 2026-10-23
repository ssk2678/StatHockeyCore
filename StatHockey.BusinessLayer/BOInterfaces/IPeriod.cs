using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IPeriod
    {
        string PeriodType { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        int Num { get; set; }
        string OrdinalNum { get; set; }
        PlayingTeam Home { get; set; }
        PlayingTeam Away { get; set; }
    }
}
