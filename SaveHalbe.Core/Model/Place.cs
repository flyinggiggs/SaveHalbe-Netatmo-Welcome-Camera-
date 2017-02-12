using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Place
    {
        public Place() { }

        [JsonProperty("city")]
        public string City { get; set; }//": "Tudor Village",

        [JsonProperty("country")]
        public string Country { get; set; }//": "US",

        [JsonProperty("timezone")]
        public string Timezone { get; set; }//": "America/New_York"
    }
}
