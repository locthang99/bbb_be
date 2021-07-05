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
using Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Application.Wrappers;
using System.Net;
using System.Text.Json;

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
            services.AddTransient(typeof(IRealEntityRepository<>), typeof(RealEntityRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IPlaylistRepository, PlaylistRepository>();
            services.AddTransient<ITypeRepository, TypeRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<IDashboardRepository, DashboardRepository>();




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
                    o.Events = new JwtBearerEvents()
                    {
                        //OnAuthenticationFailed = context =>
                        //{
                        //    var response = context.Response;
                        //    response.ContentType = "application/json";
                        //    var responseModel = new Response<object>() { Data = null };
                        //    response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        //    responseModel.Msg = "Not login";
                        //    responseModel.Code = response.StatusCode;
                        //    var result = JsonSerializer.Serialize(responseModel);

                        //    return response.WriteAsync(result);
                        //},
                        OnChallenge = context =>
                        {
                            context.HandleResponse();
                            var response = context.Response;
                            var responseModel = new Response<object>() { Data = null };
                            responseModel.Msg = "Not login";
                            responseModel.Code = (int)HttpStatusCode.Unauthorized;

                            response.ContentType = "application/json";
                            response.StatusCode = (int)HttpStatusCode.Unauthorized;
                            var result = JsonSerializer.Serialize(responseModel);
                            return response.WriteAsync(result);
                        },
                        OnForbidden = context =>
                        {
                            var response = context.Response;
                            response.ContentType = "application/json";
                            var responseModel = new Response<object>() { Data = null };
                            response.StatusCode = (int)HttpStatusCode.Forbidden;
                            responseModel.Msg = "You have not permission to change this resource";
                            responseModel.Code = response.StatusCode;
                            var result = JsonSerializer.Serialize(responseModel);

                            return response.WriteAsync(result);
                        },
                    };
                });


                        #endregion
        }

    }
}
