using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    
    public class Roster : IRoster
    {
        [JsonProperty(PropertyName = "person")]
        public Person Person { get; set; }
        [JsonProperty(PropertyName = "jerseyNumber")]
        public int JerseyNumber { get; set; }
        [JsonProperty(PropertyName = "position")]
        public Position Position { get; set; }
    }
}
