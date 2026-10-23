using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StatHockeyCore
{
    public class StatHockeyCoreConfig
    {
        public string ApplicationName { get; set; }
        public int Version { get; set; }
        public string NHLApi { get; set; }

        public string NHLPlayerImageUrl { get; set; }
    }
}
