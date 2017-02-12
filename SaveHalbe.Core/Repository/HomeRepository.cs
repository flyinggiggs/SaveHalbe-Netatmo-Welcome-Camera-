using Newtonsoft.Json;
using SaveHalbe.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbeCore.Repository
{
    public class HomeRepository
    {
        [JsonProperty("home")]
        public Home[] Home { get; set; }

        [JsonProperty("user")]
        private User User { get; set; }

        /// <summary>
        /// Default constructor. This is required for deserialzing
        /// </summary>
        public HomeRepository() { }

        //[JsonConstructor]
        public HomeRepository(RetrievedData rData)
        {
            this.Home = rData.Body.Homes;
            this.User = rData.Body.User;
        }

        public List<Home> GetHome()
        {
            return this.Home.ToList();
        }

        public User GetUser()
        {
            return this.User;
        }
    }
}
