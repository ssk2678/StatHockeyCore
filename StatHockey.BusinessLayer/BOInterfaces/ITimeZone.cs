using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ITimeZone
    {
        string Id { get; set; }
        string Offset { get; set; }
        string TZ { get; set; }
    }
}
