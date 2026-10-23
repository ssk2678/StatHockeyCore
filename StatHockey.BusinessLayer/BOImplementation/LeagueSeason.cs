using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOImplementation;
using StatHockey.BusinessLayer.BOInterfaces;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class LeagueSeason : ILeagueSeason
    {
        [JsonProperty(PropertyName = "seasons")]
        public List<Season> Seasons { get; set; }
    }
}
