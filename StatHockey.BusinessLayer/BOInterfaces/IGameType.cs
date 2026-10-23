using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IGameType
    {
        string ID { get; set; }
        string Description { get; set; }
        bool PostSeason { get; set; }

    }
}
