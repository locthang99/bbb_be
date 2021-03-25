using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ThirdPartyServices.SendMail;
using ThirdPartyServices.Storage;

namespace ThirdPartyServices
{
    public static class DependencyInjection
    {
        public static void AddThirdPartyServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<IStorageService, FileStorageService>();
            services.AddTransient<ISendMailService, SendMailService>();
            //services.AddTransient<IManageUserService, ManageUserService>();
            //services.AddTransient<IValidator<UserLoginRequest>, UserLoginValidator>();


        }

    }
}
