using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class TokenData
    {
        [JsonProperty("access_token")]
        public string Access_token { get; set; } //= new List<string>();

        [JsonProperty("refresh_token")]
        public string Refresh_token { get; set; }

        [JsonProperty("scope")]
        public string[] Scope { get; set; }

        [JsonProperty("expires_in")]
        public string Expires_in { get; set; }

        [JsonProperty("expire_in")]
        public string Expire_in { get; set; }
    }
}
