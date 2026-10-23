using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ILeagueSeason
    {
        [JsonProperty(PropertyName = "Seasons")]
        List<Season> Seasons { get; set; }
    }
}
