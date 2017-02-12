using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    //[JsonObject(MemberSerialization.OptIn)]
    public class Body
    {
        public Body() { }

        [JsonProperty("homes")]
        public Home[] Homes { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
