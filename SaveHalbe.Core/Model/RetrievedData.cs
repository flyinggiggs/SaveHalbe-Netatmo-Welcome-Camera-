using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    //[JsonObject(MemberSerialization.Fields)]
    public class RetrievedData
    {
        public RetrievedData() { }

        [JsonProperty("body")]
        public Body Body { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("time_exec")]
        public string Time_exec { get; set; }

        [JsonProperty("time_server")]
        public string Time_server { get; set; }
    }
}
