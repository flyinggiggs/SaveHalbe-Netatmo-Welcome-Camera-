using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class SnapShot
    {
        public SnapShot() { }

        [JsonProperty("id")]
        public string Id { get; set; } //: "5876fa5dc497844aab8b5072",

        [JsonProperty("version")]
        public string Version { get; set; }//": 1,

        [JsonProperty("key")]
        public string Key { get; set; }//": "69e7687ebea3efc6d3a6eda47e5c3e4dd8bb9c685a7bc95b537d7ebefcf73a48"
    }
}
