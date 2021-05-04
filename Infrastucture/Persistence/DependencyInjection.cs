using System;
using System.Collections.Generic;
using System.Text;
using Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Repositories.Repo;
using Application.Interfaces.Repo;
using Application.Interfaces.RepoBase;
using Persistence.Repositories.Base;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Application.Interfaces.UoW;
using Persistence.Repositories.UoW;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BigBlueBirdsDbContext>(options =>
            options.UseNpgsql(configuration["ConnectionStrings:BigBlueBirdsDb"],
            b => b.MigrationsAssembly(typeof(BigBlueBirdsDbContext).Assembly.FullName))
            );
            #region Repositories
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(IExtensionEntityRepository<>), typeof(ExtensionEntityRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IPlaylistRepository, PlaylistRepository>();
            services.AddTransient<ITypeRepository, TypeRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();




            services.AddTransient<UserManager<User>, UserManager<User>>();
            services.AddTransient<SignInManager<User>, SignInManager<User>>();
            services.AddTransient<RoleManager<Role>, RoleManager<Role>>();
            //services.AddTransient<IManageUserService, ManageUserService>();
            //services.AddTransient<IValidator<UserLoginRequest>, UserLoginValidator>();
            #endregion
            #region DI

            services.AddIdentity<User, Role>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
            }
            )
            .AddEntityFrameworkStores<BigBlueBirdsDbContext>()
            .AddDefaultTokenProviders();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = true;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidIssuer = configuration["JWTSettings:Issuer"],
                        ValidAudience = configuration["JWTSettings:Issuer"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWTSettings:Key"]))
                    };
                    //o.Events = new JwtBearerEvents()
                    //{
                    //    OnAuthenticationFailed = c =>
                    //    {
                    //        c.NoResult();
                    //        c.Response.StatusCode = 500;
                    //        c.Response.ContentType = "text/plain";
                    //        return c.Response.WriteAsync(c.Exception.ToString());
                    //    },
                    //    OnChallenge = context =>
                    //    {
                    //        context.HandleResponse();
                    //        context.Response.StatusCode = 401;
                    //        context.Response.ContentType = "application/json";
                    //        var result = JsonConvert.SerializeObject(new Response<string>("You are not Authorized"));
                    //        return context.Response.WriteAsync(result);
                    //    },
                    //    OnForbidden = context =>
                    //    {
                    //        context.Response.StatusCode = 403;
                    //        context.Response.ContentType = "application/json";
                    //        var result = JsonConvert.SerializeObject(new Response<string>("You are not authorized to access this resource"));
                    //        return context.Response.WriteAsync(result);
                    //    },
                    //};
                });


                        #endregion
        }

    }
}
