using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Person
    {
        public Person() { }

        [JsonProperty("id")]
        public string Id { get; set; }//": "17eaf701-f270-429a-9b2a-dc02e9b3c644",

        [JsonProperty("last_seen")]
        public string Last_seen { get; set; }//": 1484192342,

        [JsonProperty("out_of_sight")]
        public string Out_of_sight { get; set; } //": true,

        [JsonProperty("face")]
        public Face Face { get; set; }

        [JsonProperty("pseudo")]
        public string Pseudo { get; set; }//": "Sharpay"

    }
}
