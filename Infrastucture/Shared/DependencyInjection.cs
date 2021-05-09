using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ThirdPartyServices.FacebookAuth;
using ThirdPartyServices.Hash;
using ThirdPartyServices.RedisCache;
using ThirdPartyServices.SendMail;
using ThirdPartyServices.Storage;

namespace ThirdPartyServices
{
    public static class DependencyInjection
    {
        public static void AddThirdPartyServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IStorageService, FileStorageService>();
            services.AddSingleton<ISendMailService, SendMailService>();
            services.AddTransient<IFacebookAuthService, FacebookAuthService>();
            services.AddTransient<IHashService, HashService>();
            services.AddSingleton<IRedisService, RedisService>();
            //services.AddTransient<IManageUserService, ManageUserService>();
            //services.AddTransient<IValidator<UserLoginRequest>, UserLoginValidator>();


        }

    }
}
