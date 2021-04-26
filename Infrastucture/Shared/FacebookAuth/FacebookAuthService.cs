using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.FacebookAuth.DTOs;

namespace ThirdPartyServices.FacebookAuth
{
    public class FacebookAuthService : IFacebookAuthService
    {
        private const string TokenValidationUrl = "https://graph.facebook.com/debug_token?input_token={0}&access_token={1}|{2}";
        private const string UserInforUrl = "https://graph.facebook.com/me?fields=first_name,last_name,picture,email&access_token={0}";
        private readonly IHttpClientFactory _httpClientFactoty;
        private string AppId;
        private string AppSecret;
        public FacebookAuthService(IHttpClientFactory httpClientFactoty,IConfiguration config)
        {
            _httpClientFactoty = httpClientFactoty;
            AppId = config["Facebook_Auth:AppId"];
            AppSecret = config["Facebook_Auth:AppSecret"];

        }

        public async Task<FBValidateTokenDTO> ValidateAccessToken(string Token)
        {
            var FormatUrl = string.Format(TokenValidationUrl, Token, AppId, AppSecret);
            var rs = await _httpClientFactoty.CreateClient().GetAsync(FormatUrl);
            rs.EnsureSuccessStatusCode();
            var res = await rs.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FBValidateTokenDTO>(res);
        }

        public async Task<FBUserInforDTO> GetUserInfor(string Token)
        {
            var FormatUrl = string.Format(UserInforUrl, Token);
            var rs = await _httpClientFactoty.CreateClient().GetAsync(FormatUrl);
            rs.EnsureSuccessStatusCode();
            var res = await rs.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FBUserInforDTO>(res);
        }
    }
}
