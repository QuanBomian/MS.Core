using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.Authorization;
using AspNetCore.Application.Authorization.Dto;
using AspNetCore.Application.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IJwtAppService _jwtService;
        private readonly IUserInfoAppService _userInfoService;
        public LoginController(IJwtAppService jwtservice,IUserInfoAppService userInfoAppService)
        {
            _jwtService = jwtservice;
            _userInfoService = userInfoAppService;
        }
        [HttpGet]
        [Route("Token")]
        public JsonResult JwtStr(string username,string password)
        {
            UserInfoDto userInfo = _userInfoService.GetUserInfo(username, password);
            if (userInfo.Success == true)
            {
                JwtTokenDto jwtToken = new JwtTokenDto
                {
                    UserId = userInfo.UserId,
                    Role = userInfo.RoleNames.First()
                };
                string jwtStr = _jwtService.IssueJwtToken(jwtToken);
                return new JsonResult(new
                {
                    success=true,
                    token = jwtStr
                });
            }
            else
            {
                return new JsonResult(new
                {
                    success = false
                });
            }
        }
    }
}