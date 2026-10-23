using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IDivision
    {
        string Id { get; set; }
        string Name { get; set; }
        string NameShort { get; set; }
        string Link { get; set; }
        string Abbreviation { get; set; }
    }
}
