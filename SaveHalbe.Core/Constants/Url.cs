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

        public static readonly string getCameraPictureUrl = "https://api.netatmo.com/api/getcamerapicture";

        public static readonly string faceDetectEndPoint = "https://westus.api.cognitive.microsoft.com/face/v1.0/detect?";

        public static readonly string criminalList = "http://s1.ibtimes.com/sites/www.ibtimes.com/files/styles/lg/public/2014/10/29/gregory-lewis-massachusetts-most-wanted-list.png";
    }
}
