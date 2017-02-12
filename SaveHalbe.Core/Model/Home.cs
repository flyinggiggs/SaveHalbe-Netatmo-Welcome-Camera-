using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Home
    {
        public Home() { }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("persons")]
        public Person[] Persons { get; set; }

        [JsonProperty("place")]
        public Place Place { get; set; }

        [JsonProperty("cameras")]
        public Camera[] Cameras { get; set; }

        [JsonProperty("events")]
        public Event[] Events { get; set; }
    } 
}
