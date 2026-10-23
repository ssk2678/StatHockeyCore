using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    public interface IPosition
    {
        char Code { get; set; }
        string Name { get; set; }
        string Type { get; set; }
        string Abbreviation { get; set; }
    }
}
