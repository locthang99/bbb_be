using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BigBlueBirdsDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("BigBlueBirdsDb"), options => options.EnableRetryOnFailure())
            );
            #region Repositories
            #endregion
        }

    }
}
