using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using SaveHalbe.Core.Model;


namespace SaveHalbe.Core.Helper
{
    public class TokenHelper
    {
        public static string GetAccesToken(string userId, string password)
        {
            string accessToken = string.Empty;

            try
            {
                using (var client = new HttpClient())
                {
                    var values = new Dictionary<string, string>
                    {
                        {"client_id", Constants.Credential.client_id},
                        {"client_secret", Constants.Credential.client_secret},
                        {"grant_type", Constants.Credential.grant_type},
                        {"username", userId},
                        {"password", password},
                        {"scope", Constants.Credential.scope}
                    };

                    var content = new FormUrlEncodedContent(values);

                    var response = client.PostAsync(Constants.Url.tokenEndPointUrl, content);

                    var responseString = response.Result.Content.ReadAsStringAsync();
                    responseString.Wait();

                    accessToken = ParseAccessToken(responseString.Result);
                }
            }
            catch (Exception)
            {
                // Handle Exception
            }

            return accessToken;
        }

        private static string ParseAccessToken(string responseString)
        {
            var retrievedToekn = JsonConvert.DeserializeObject<TokenData>(responseString);

            return retrievedToekn.Access_token;
        }
    }
}
