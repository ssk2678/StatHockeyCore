using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;


namespace StatHockey.BusinessLayer.BOImplementation
{    
    public class TeamRoster : ITeamRoster
    {
        [JsonProperty(PropertyName = "person")]
        public Person Person { get; set; }
        public int JerseyNumber { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
    }
}
