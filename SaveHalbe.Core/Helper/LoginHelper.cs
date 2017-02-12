using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveHalbe.Core.Helper
{
    public class LoginHelper
    {
        public static string ValidateLogin(string userId, string password)
        {
            string accessToken = string.Empty;

            accessToken = TokenHelper.GetAccesToken(userId, password);

            return accessToken; 
        }
    }
}
