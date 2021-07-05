using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ThirdPartyServices.Deeplearning;
using ThirdPartyServices.FacebookAuth;
using ThirdPartyServices.Hash;
using ThirdPartyServices.Payment;
using ThirdPartyServices.RedisCache;
using ThirdPartyServices.SendMail;
using ThirdPartyServices.Storage;
using ThirdPartyServices.StringService;

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
            services.AddTransient<IMomoService, MomoService>();
            services.AddSingleton<IRedisService, RedisService>();
            services.AddSingleton<IDeeplearningService, DeeplearningService>();
            services.AddSingleton<IStringService, ThirdPartyServices.StringService.StringService>();


            //services.AddTransient<IManageUserService, ManageUserService>();
            //services.AddTransient<IValidator<UserLoginRequest>, UserLoginValidator>();


        }

    }
}
