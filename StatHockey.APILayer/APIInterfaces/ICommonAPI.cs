using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.APILayer.APIInterfaces
{
    interface ICommonAPI
    {
       Task<LeagueSeason> GetSeasons();
    }
}
