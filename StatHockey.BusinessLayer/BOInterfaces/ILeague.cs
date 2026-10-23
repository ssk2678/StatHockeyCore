using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ILeague
    {
        string Copyright { get; set; }
        List<Team> Teams { get; set; }
        List<Person> People { get; set; }
    }
}
