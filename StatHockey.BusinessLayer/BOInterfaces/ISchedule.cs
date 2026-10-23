 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ISchedule
    {
        string Copyright { get; set; }
        int TotalItems { get; set; }
        int TotalEvents { get; set; }
        int TotalMatches { get; set; }
        int Wait { get; set; }
        
        List<TeamScheduleDateData> Dates { get; set; }
    }
}
