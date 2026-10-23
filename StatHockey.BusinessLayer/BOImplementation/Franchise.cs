using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatHockey.BusinessLayer.BOInterfaces;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOImplementation
{
    public class Franchise : IFranchise
    {
        [JsonProperty(PropertyName = "franchiseId")]
        public string FranchiseId { get; set; }
        [JsonProperty(PropertyName = "teamName")]
        public string TeamName { get; set; }
        [JsonProperty(PropertyName = "Link")]
        public string Link { get; set; }
    }
}
