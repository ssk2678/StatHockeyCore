using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StatHockey.BusinessLayer.BOInterfaces
{
    interface IFranchise
    {
        [JsonProperty(PropertyName = "franchiseId")]
        string FranchiseId { get; set; }
        [JsonProperty(PropertyName = "teamName")]
        string TeamName { get; set; }
        [JsonProperty(PropertyName = "link")]
        string Link { get; set; }
    }
}
