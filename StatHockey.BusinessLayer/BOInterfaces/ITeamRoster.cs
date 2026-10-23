using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StatHockey.BusinessLayer.BOImplementation;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface ITeamRoster
    {   
       // [JsonProperty(PropertyName="person")]
        Person Person { get; set; }
        int JerseyNumber { get; set; }
       // [JsonProperty(PropertyName = "position")]
        Position Position { get; set; }
    }
}
