using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Application.Authorization;
using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Application.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace AspNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IJwtAppService _jwtService;
        private readonly IUserInfoAppService _userInfoService;
        private readonly IDistributedCache _cache;
        public UsersController(IJwtAppService jwtservice, IUserInfoAppService userInfoAppService, IDistributedCache cache)
        {
            _jwtService = jwtservice;
            _userInfoService = userInfoAppService;
            _cache = cache;
        }
        [HttpGet]
        [Route("login")]
        public async Task<JsonResult> JwtStrAsync(string username, string password)
        {
            UserInfoDto userInfo = _userInfoService.GetUserInfo(username, password);
            if (userInfo.Success == true)
            {
                JwtTokenDto jwtToken = new JwtTokenDto
                {
                    UserId = userInfo.UserId,
                    Role = userInfo.RoleNames
                };
                string jwtStr = _jwtService.IssueJwtToken(jwtToken);
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(userInfo);

                var encodedstr = Encoding.UTF8.GetBytes(json);
                await _cache.SetAsync(jwtStr, encodedstr);
                return new JsonResult(new
                {
                    code = 20000,
                    username = userInfo.Username,
                    roles = userInfo.RoleNames,
                    token = jwtStr
                });


            }
            else
            {
                return new JsonResult(new
                {
                    code=50008
                });
            }
        }
        [Route("info")]
        [HttpGet]

        public async Task<JsonResult> GetUserInfoAsync(string token)
        {
            var jsonObj = await _cache.GetAsync(token);
            var decodedstr = Encoding.UTF8.GetString(jsonObj);
            UserInfoDto userInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInfoDto>(decodedstr);
            return new JsonResult(
                new
                {
                    code = 20000,
                    userInfo
                });

        }
        [HttpPost]
        [Route("logout")]
        public async Task<JsonResult> LogoutAsync(string token)
        {
            await _cache.RemoveAsync(token);
            return new JsonResult(
                new
                {
                    code = 20000,
             
                });
        }
    }

}