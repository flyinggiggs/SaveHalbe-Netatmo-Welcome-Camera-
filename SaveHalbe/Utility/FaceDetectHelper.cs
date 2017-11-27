using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using SaveHalbe.Core.Constants;
using SaveHalbe.Core.Model;

namespace SaveHalbe.Utility
{
    public class FaceDetectHelper
    {

        static public DetectedFace MakeRequest(byte[] byteData, bool isWebImage = false)
        {
            try
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // Request headers
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Credential.ocpApimSubscriptionKey);

                // Request parameters
                queryString["returnFaceId"] = "true";
                queryString["returnFaceLandmarks"] = "false";
                queryString["returnFaceAttributes"] = "age,gender,smile,facialHair,glasses,headPose";

                var uri = Url.faceDetectEndPoint + queryString;

                if (isWebImage)
                {
                    var values = new Dictionary<string, string>
                    {
                        {"url", Url.criminalList },
                    };

                    var content = JsonConvert.SerializeObject(values);
                    var httpcontent = new StringContent(content, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(uri, httpcontent);

                    var responseString = response.Result.Content.ReadAsStringAsync();
                    //respo

                    var faceInfo = JsonConvert.DeserializeObject<DetectedFace[]>(responseString.Result);

                    return faceInfo[0];
                }

                else
                {
                    using (var content = new ByteArrayContent(byteData))
                    {
                        content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                        var response = client.PostAsync(uri, content);
                        response.Wait();
                        var responseString = response.Result.Content.ReadAsStringAsync();
                        var faceInfo = JsonConvert.DeserializeObject<DetectedFace[]>(responseString.Result);

                        return faceInfo[0];
                    }
                }
            }
            catch (Exception e)
            {
                //handle
            }
            return null;
        }
    }
}