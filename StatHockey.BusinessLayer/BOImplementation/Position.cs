using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Position : IPosition
    {
        [JsonProperty(PropertyName = "code")]        
        public char Code { get; set; }               
        [JsonProperty(PropertyName = "name")]       
        public string Name { get; set; }
        [JsonProperty(PropertyName = "type")]      
        public string Type { get; set; }
        [JsonProperty(PropertyName = "abbreviation")]        
        public string Abbreviation { get; set; }
    }
}
