using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Application.Authorization;
using AspNetCore.Application.UserInfo;
using AspNetCore.Application.VillagerInfo;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.UserInfo;
using AspNetCore.Domain.VillagerInfo;
using AspNetCore.Entity.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Swashbuckle.AspNetCore.Swagger;

namespace AspNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1.0.0",
                    Title = "管理系统 API",
                    Description = "框架说明文档",
                    TermsOfService = "None",
                    Contact = new Swashbuckle.AspNetCore.Swagger.Contact { Name = "民情档案管理系统", Email = "731988353@qq.com", Url = "https://quanbomian.github.io/" }
                });
                #region Token绑定到ConfigureServices
                //添加header验证信息
                //c.OperationFilter<SwaggerHeader>();
                var security = new Dictionary<string, IEnumerable<string>> { { "MS.Core", new string[] { } }, };
                c.AddSecurityRequirement(security);
                //方案名称“Blog.Core”可自定义，上下一致即可
                c.AddSecurityDefinition("MS.Core", new ApiKeyScheme
                {
                    Description = "JWT授权(数据将在请求头中进行传输) 直接在下框中输入Bearer {token}（注意两者之间是一个空格）\"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = "header",//jwt默认存放Authorization信息的位置(请求头中)
                    Type = "apiKey"
                });
                #endregion
            });

            #endregion

            #region Token服务注册
            services.AddSingleton<IMemoryCache>(factory =>
            {
                var cache = new MemoryCache(new MemoryCacheOptions());
                return cache;
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Client", policy => policy.RequireRole("Client").Build());
                options.AddPolicy("Admin", policy => policy.RequireRole("Admin").Build());
                options.AddPolicy("SystemOrAdmin", policy => policy.RequireRole("Admin", "System").Build());
            });
            #endregion

            /*#region 数据库上下文

            services.AddDbContext<MsContext>(
                options => options.UseNpgsql(Configuration.GetConnectionString("NpgSql")));

            #endregion*/

            #region 依赖注入

            services.AddTransient<IVillagerAppService, VillagerAppService>();
            services.AddTransient<IVillagerDomain, VillagerDomain>();
            services.AddTransient<IVillagerRepository, VillagerRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRoleRepository, RoleRepository>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
            services.AddTransient<IUserInfoDomain, UserInfoDomain>();
            services.AddTransient<IUserInfoAppService, UserInfoAppService>();
    
            services.AddTransient<IJwtAppService, JwtAppService>();
            services.AddDbContext<MsContext>();

            #endregion

            #region 跨域

            services.AddCors(options =>
                options.AddPolicy("VuePolicy",
                    builder =>
                        builder.WithOrigins("http://localhost:9528").
                            AllowAnyHeader().
                            AllowAnyMethod().
                            AllowCredentials()));

            #endregion

            var audienceConfig = Configuration.GetSection("JwtConfig");
            string symmetricKey = audienceConfig["Secret"];
            byte[] keyArrayBytes = Encoding.ASCII.GetBytes(symmetricKey);
            SymmetricSecurityKey sigingKey = new SymmetricSecurityKey(keyArrayBytes);
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = audienceConfig["Issuer"],
                ValidAudience = audienceConfig["Audience"],
                ValidateLifetime = true,
                IssuerSigningKey = sigingKey,
                ClockSkew = TimeSpan.Zero,
                RequireExpirationTime = true

            };
            services.AddAuthentication(
                    options =>
                    {
                        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                    })
                .AddJwtBearer(o => { o.TokenValidationParameters = tokenValidationParameters; });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiHelp V1");
            });
            #endregion

            app.UseCors("VuePolicy");
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
