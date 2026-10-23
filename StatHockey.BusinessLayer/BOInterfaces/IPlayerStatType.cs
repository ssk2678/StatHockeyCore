using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IPlayerStatType
    {
        string DisplayName { get; set; }
        GameType GameType { get; set; }

    }
}
