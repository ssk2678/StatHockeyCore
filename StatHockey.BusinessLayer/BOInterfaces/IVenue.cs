using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOI = StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IVenue
    {
        string Name { get; set; }
        string Link { get; set; }
        string City { get; set; }
        BOI.TimeZone TimeZone { get; set; }
    }
}
