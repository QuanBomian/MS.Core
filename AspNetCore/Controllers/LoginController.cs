using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.Authorization;
using AspNetCore.Application.Authorization.Dto;
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

        public LoginController(IJwtAppService service)
        {
            _jwtService = service;
        }
        [HttpGet]
        [Route("Token")]
        public JsonResult JwtStr(int id = 1,string role = "Admin")
        {
            JwtTokenDto jwtToken = new JwtTokenDto
            {
                UserId = id,
                Role = role
            };
            string jwtStr = _jwtService.IssueJwtToken(jwtToken);
            return new JsonResult(Ok(new
            {
                success = true,
                token = jwtStr
            }));

        }
    }
}