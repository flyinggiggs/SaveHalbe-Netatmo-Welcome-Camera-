using SaveHalbe.Core.Model;
using SaveHalbeCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json;

namespace SaveHalbeCore.Service
{
    //[JsonObject(MemberSerialization.Fields)]
    public class HomeDataService
    {
        [JsonProperty ("homeRepository")]
        public HomeRepository HomeRepository { get; set; }

        /// <summary>
        /// Default constructor. This is required for deserialzing
        /// </summary>
        public HomeDataService() { }

        public HomeDataService(RetrievedData rData)
        {
            if(this.HomeRepository == null)
            {
                this.HomeRepository = new HomeRepository(rData);
            }
        }

        public HomeRepository GetHomeRepository()
        {
            return this.HomeRepository;
        }
    }
}
