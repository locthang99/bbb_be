using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyServices.FacebookAuth.DTOs;

namespace ThirdPartyServices.FacebookAuth
{
    public interface IFacebookAuthService
    {
        Task<FBValidateTokenDTO> ValidateAccessToken(string Token);
        Task<FBUserInforDTO> GetUserInfor(string Token);
    }
}
