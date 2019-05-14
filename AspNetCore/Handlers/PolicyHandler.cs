//-----------------------------------------------------------------------
// <copyright file= "PolicyHandler.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Created DateTime: 2019/1/15 19:23:35 
// Modified by:
// Description: 角色策略授权处理
//-----------------------------------------------------------------------
using AspNetCore.Application.Authorization;
using AspNetCore.Application.MenuInfo;
using AspNetCore.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AspNetCore.Handlers
{
    public class PolicyHandler : AuthorizationHandler<PolicyRequirement>
    {
        /// <summary>
        /// 授权方式（cookie, bearer, oauth, openid）
        /// </summary>
        public IAuthenticationSchemeProvider Schemes { get; set; }

        /// <summary>
        /// jwt 服务
        /// </summary>
        private readonly IJwtAppService _jwtApp;

        private readonly IMenuAppService _menuApp;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="schemes"></param>
        /// <param name="jwtApp"></param>
        /// <param name="menuApp"></param>
        public PolicyHandler(IAuthenticationSchemeProvider schemes, IJwtAppService jwtApp,IMenuAppService menuApp)
        {
            Schemes = schemes;
            _jwtApp = jwtApp;
            _menuApp = menuApp;
        }

        //授权处理
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PolicyRequirement requirement)
        {
            //Todo：获取角色、Url 对应关系
            List<Menu> list = await _menuApp.GetAll();
               

            var httpContext = (context.Resource as AuthorizationFilterContext).HttpContext;

            //获取授权方式
            var defaultAuthenticate = await Schemes.GetDefaultAuthenticateSchemeAsync();
            if (defaultAuthenticate != null)
            {
                //验证签发的用户信息
                var result = await httpContext.AuthenticateAsync(defaultAuthenticate.Name);
                if (result.Succeeded)
                {
                    //判断是否为已停用的 Token
                    if (!await _jwtApp.IsCurrentActiveTokenAsync())
                    {
                        context.Fail();
                        return;
                    }

                    httpContext.User = result.Principal;

                    //判断角色与 Url 是否对应
                    //
                    var url = httpContext.Request.Path.Value;
                    var role = httpContext.User.Claims.Where(c => c.Type == ClaimTypes.Role).Select(x=>x.Value).ToList();
                    var menu = list.Where(x => url.Contains(x.Url)&&role.Contains(x.RoleName)).FirstOrDefault();

                    if (menu == null)
                    {
                        context.Fail();
                        return;
                    }
                  
                    
                  /*  var menu = list.Where(x => x.Role.Equals(role) && x.Url.ToLower().Equals(url)).FirstOrDefault()*/;

                  

                    //判断是否过期
                    if (DateTime.Parse(httpContext.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Expiration).Value) >= DateTime.UtcNow)
                    {
                        context.Succeed(requirement);
                    }
                    else
                    {
                        context.Fail();
                    }
                    return;
                }
            }
            context.Fail();
        }

       
    }
}
