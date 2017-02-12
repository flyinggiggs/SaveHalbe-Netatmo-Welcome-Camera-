using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Constants
{
    public class Url
    {
        public static readonly string tokenEndPointUrl = "https://api.netatmo.com/oauth2/token";

        public static readonly string homeDataEndPointUrl = "https://api.netatmo.net/api/gethomedata?access_token=";
    }
}
