using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class DateSetup
    {
        public DateSetup() { }

        [JsonProperty("sec")]
        public string Sec { get; set; }//: 1484190764,

        [JsonProperty("usec")]
        public string Usec { get; set; }//": 848000
    }
}
