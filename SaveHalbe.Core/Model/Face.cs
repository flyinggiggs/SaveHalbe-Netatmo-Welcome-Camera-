using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Face
    {
        public Face() { }

        [JsonProperty("id")]
        public string Id { get; set; }//": "5876fa5dc497844aab8b5071",

        [JsonProperty("version")]
        public string Version { get; set; }//": 1,

        [JsonProperty("key")]
        public string Key { get; set; }//": "ec654a71e1e5545edc6cd55ba34fb545a4f6c6e829a0f2a220145767102e1be2"
    }
}
