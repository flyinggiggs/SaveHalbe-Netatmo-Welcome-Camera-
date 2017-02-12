using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    //[JsonObject(MemberSerialization.Fields)]
    public class User
    {
        public User() { }

        [JsonProperty("reg_locale")]
        public string Reg_locale { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }
    }
}
