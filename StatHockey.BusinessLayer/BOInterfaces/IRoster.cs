using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IRoster
    {
        Person Person { get; set; }
        int JerseyNumber { get; set; }
        Position Position { get; set; }
    }
}
