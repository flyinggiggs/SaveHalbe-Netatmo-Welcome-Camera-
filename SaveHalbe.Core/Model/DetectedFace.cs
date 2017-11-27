using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Model
{
    public class DetectedFace
    {
        public string faceId; //\":\"e939ef1c-2d02-489f-8669-6fe62feae408\",
        public FaceRectangle faceRectangle;
        public FaceAttributes faceAttributes;
        public string glasses;
        public HeadPose headPose;  
    }

    public class FaceRectangle
    {
        public object top;
        public object left;
        public object width;
        public object height;
        //{\"top\":51,\"left\":79,\"width\":97,\"height\":97}
    }

    public class FaceAttributes
    {
        public object age;
        public string gender;
        public string smile;
        public FacialHair facialHair;

      //  "faceAttributes\":{\"age\":53.3}}
    }

    public class FacialHair
    {
        public object mustache;
        public object beard;
        public object sideburns;
    }

    public class HeadPose
    {
        public object roll;
        public object yea;
        public object pitch;
    }
}
