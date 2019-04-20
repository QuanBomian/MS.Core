//-----------------------------------------------------------------------
// <copyright file= "SecretAppService.cs">
//     Copyright (c) Danvic712. All rights reserved.
// </copyright>
// Author: Danvic712
// Created DateTime: 2018/12/19 15:03:39 
// Modified by:
// Description: 
//-----------------------------------------------------------------------
using AspNetCore.Application.Authorization;
using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Domain.UserInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.Authorization
{
    public class SecretAppService : ISecretAppService
    {
        #region Initialize

        /// <summary>
        /// 领域接口
        /// </summary>
        private readonly IUserDomain _user;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="secret"></param>
        public SecretAppService(IUserDomain user)
        {
            _user = user;
        }

        #endregion

        #region API Implements

        /// <summary>
        /// 获取登录用户信息
        /// </summary>
        /// <param name="account">账户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public async Task<UserDto> GetCurrentUserAsync(string account, string password)
        {
            var user = await _user.GetUserForLoginAsync(account, password);

            //Todo：AutoMapper 做实体转换

            return null;
        }

        #endregion
    }
}
