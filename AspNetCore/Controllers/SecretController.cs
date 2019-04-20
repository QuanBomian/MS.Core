//-----------------------------------------------------------------------
// <copyright file= "SecretController.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Created DateTime: 2018/12/19 14:58:39 
// Modified by:
// Description: Jwt 授权
//-----------------------------------------------------------------------
using AspNetCore.Application.Authorization;
using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Application.LoginInfo;
using AspNetCore.Application.UserInfo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    [ApiController]
 
    [Authorize(Policy = "Permission")]
    [Route("api/[controller]")]
    public class SecretController : ControllerBase
    {
        #region Initialize

        /// <summary>
        /// Jwt 服务
        /// </summary>
        private readonly IJwtAppService _jwtApp;

        /// <summary>
        /// 日志记录服务
        /// </summary>

        private readonly ILoginInfoAppService _loginApp;

        /// <summary>
        /// 配置信息
        /// </summary>
        public IConfiguration _configuration { get; }

        /// <summary>
        /// Ctor
        /// </summary>
    
        /// <param name="configuration"></param>
        /// <param name="jwtApp"></param>
        /// <param name="logininfoApp"></param>
       
        public SecretController(IConfiguration configuration,
            IJwtAppService jwtApp,ILoginInfoAppService logininfoApp)
        {
            _configuration = configuration;
            _jwtApp = jwtApp;
            _loginApp = logininfoApp;
          
           
        }

        #endregion

        #region APIs

        /// <summary>
        /// 停用 Jwt 授权数据
        /// </summary>
        /// <returns></returns>
        [HttpPost("deactivate")]
        public async Task<IActionResult> CancelAccessToken()
        {
            await _jwtApp.DeactivateCurrentAsync();
            return new JsonResult(new
            {
                code = 20000
            });
        }
        [HttpGet("userInfo")]
        
        public JsonResult GetUserInfo(string token)
        {
            var data = _jwtApp.GetExistenceToken(token);
           
                return new JsonResult(new
                {
                    code = 20000,
                    data
                });
   
          
        }

        /// <summary>
        /// 获取 Jwt 授权数据
        /// </summary>
        /// <param name="dto">授权用户信息</param>
        [HttpPost("token")]
        [AllowAnonymous]
        public  JsonResult LoginAsync([FromBody] SecretDto dto)
        {
            //Todo：获取用户信息
            //var user = new UserDto
            //{
            //    Id = Guid.NewGuid(),
            //    UserName = "yuiter",
            //    Role = Guid.Empty,
            //    Email = "yuiter@yuiter.com",
            //    Phone = "13912345678",
            //};

            var user = _loginApp.GetUserInfo(dto.UserName, dto.Password);

            if (user == null)
            {
                var datanull = new JwtResponseDto
                {
                    Access = "无权访问",
                    Type = "Bearer",
                    Profile = new Profile
                    {
                        UserName = dto.UserName,
                        Auths = 0,
                        Expires = 0
                    }
                };
                return new JsonResult
                (
                    new
                    {
                        code = 20000,
                        data=datanull
                    }
                );
            }
             
            var jwt = _jwtApp.Create(user);
            var data = new JwtResponseDto
            {
                Access = jwt.Token,
                Type = "Bearer",
                Profile = new Profile
                {
                    UserName = user.UserName,
                    Auths = jwt.AuthTime,
                    Expires = jwt.ExpTime
                }
            };
            return new JsonResult
            (new {
                code = 20000,
                data

            });
            
        }

        /// <summary>
        /// 刷新 Jwt 授权数据
        /// </summary>
        /// <param name="dto">刷新授权用户信息</param>
        /// <returns></returns>
        [HttpPost("refresh")]
        public async Task<IActionResult> RefreshAccessTokenAsync([FromBody] SecretDto dto)
        {
            var userProfile = _jwtApp.GetExistenceToken(dto.Token);
            var user = new UserDto
            {
                UserName = userProfile.Name,
                Id = userProfile.UserId,
                RoleName = userProfile.RoleNames
            };
            //if (user == null)
            //    return Ok(new JwtResponseDto
            //    {
            //        Access = "无权访问",
            //        Type = "Bearer",
            //        Profile = new Profile
            //        {
            //            UserName = dto.UserName,
            //            Auths = 0,
            //            Expires = 0
            //        }
            //    });

            var jwt = await _jwtApp.RefreshAsync(dto.Token, user);
            var data = new JwtResponseDto
            {
                Access = jwt.Token,
                Type = "Bearer",
                Profile = new Profile
                {
                    UserName = user.UserName,
                    Auths = jwt.Success ? jwt.AuthTime : 0,
                    Expires = jwt.Success ? jwt.ExpTime : 0
                }
            };
            return new JsonResult(
                new {
                    code = 20000,data
                });
        }

        #endregion
    }
}