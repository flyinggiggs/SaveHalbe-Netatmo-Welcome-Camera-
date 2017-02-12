using Newtonsoft.Json;
using SaveHalbe.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace SaveHalbe.Core.Helper
{
    public class RetrieveDataHelper
    {
        public static RetrievedData GetData(string accessToken)
        {
            RetrievedData retrievedData = null;
            try
            {
                using (var client = new HttpClient())
                {
                    var accessTokenDic = new Dictionary<string, string>
                    {
                        {"access_token", accessToken}
                    };

                    var encodedAccessToken = new FormUrlEncodedContent(accessTokenDic);

                    var response = client.PostAsync(Constants.Url.homeDataEndPointUrl, encodedAccessToken);

                    var responseString = response.Result.Content.ReadAsStringAsync();
                    responseString.Wait();

                    retrievedData = JsonConvert.DeserializeObject<RetrievedData>(responseString.Result);
                }
            }
            catch (Exception)
            {
                // Handle Exception
            }

            return retrievedData;
        }
    }
}
