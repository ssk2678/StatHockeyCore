using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IShootoutInfo
    {
        PlayingTeam Home { get; set; }
        PlayingTeam Away { get; set; }
    }
}
