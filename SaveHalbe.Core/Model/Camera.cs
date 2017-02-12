using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class Camera
    {
        public Camera() { }

        [JsonProperty("id")]
        public string Id { get; set; } //": "70:ee:50:21:36:43",

        [JsonProperty("type")]
        public string Type { get; set; } //": "NACamera",

        [JsonProperty("status")]
        public string Status { get; set; } //": "on",

        [JsonProperty("sd_status")]
        public string Sd_status { get; set; } //": "on",

        [JsonProperty("alim_status")]
        public string Alim_status { get; set; } //": "on",

        [JsonProperty("name")]
        public string Name { get; set; } //": "Jcamera",

        [JsonProperty("date_setup")]
        public DateSetup Date_setup { get; set; }
    }
}
