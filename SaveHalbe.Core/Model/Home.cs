using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    //[JsonObject(MemberSerialization.Fields)]
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

 
    public class Place
    {
        public Place() { }

        [JsonProperty("city")]
        public string City { get; set; }//": "Tudor Village",

        [JsonProperty("country")]
        public string Country { get; set; }//": "US",

        [JsonProperty("timezone")]
        public string Timezone { get; set; }//": "America/New_York"
    }


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


    public class DateSetup
    {
        public DateSetup() { }

        [JsonProperty("sec")]
        public string Sec { get; set; }//: 1484190764,

        [JsonProperty("usec")]
        public string Usec { get; set; }//": 848000
    }

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


    public class SnapShot
    {
        public SnapShot() { }

        [JsonProperty("id")]
        public string Id { get; set; } //: "5876fa5dc497844aab8b5072",

        [JsonProperty("version")]
        public string Version { get; set; }//": 1,

        [JsonProperty("key")]
        public string Key { get; set; }//": "69e7687ebea3efc6d3a6eda47e5c3e4dd8bb9c685a7bc95b537d7ebefcf73a48"
    }
}
