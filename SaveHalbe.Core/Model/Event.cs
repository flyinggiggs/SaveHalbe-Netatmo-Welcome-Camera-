using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Event
    {
        public Event() { }

        [JsonProperty("id")]
        public string Id { get; set; }//": "58854b41698de66865e4b35c",

        [JsonProperty("type")]
        public string Type { get; set; }//": "connection",

        [JsonProperty("time")]
        public string Time { get; set; }//": 1485130560,

        [JsonProperty("camera_id")]
        public string Camera_id { get; set; }//": "70:ee:50:21:36:43",

        [JsonProperty("person_id")]
        public string Person_id;//": "17eaf701-f270-429a-9b2a-dc02e9b3c644",

        [JsonProperty("snapshot")]
        public SnapShot Snapshot { get; set; }//

        [JsonProperty("message")]
        public string Message { get; set; }//": "Jcamera connected" "<b>Sharpay</b> seen"
    }
}
