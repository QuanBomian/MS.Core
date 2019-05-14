using AspNetCore.Application.Authorization;
using AspNetCore.Application.LoginInfo;
using AspNetCore.Application.UserInfo;
using AspNetCore.Application.UserInfo.Dto;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "Permission")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _service;
        private readonly ILoginInfoAppService _loginService;
        public UsersController(IUserAppService service,ILoginInfoAppService loginService)
        {
            _service = service;
            _loginService = loginService; 
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] UserQueryDto condition)
        {
            if (condition.UserName != null)
            {
                var list = _service.Search(condition);
                return new JsonResult(new
                {
                    code = 20000,
                    list
                });

            }
            var items = await _service.GetAll();
            return new JsonResult(new
            {
                code = 20000,
                items
            });
        }
        // GET: api/Userr/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Userr
        [HttpPost]
        public JsonResult Post([FromBody] User User)
        {
            _service.Add(User);
            return new JsonResult(new
            {
                code = 20000
            });
        }
        [HttpPut]
        [Route("Reset")]
        public JsonResult Reset([FromBody] UserResetDto dto)
        {
            var user = _loginService.ValidatePassword(dto.UserName, dto.RawPassword);
            if(user == null)
            {
                return new JsonResult(new
                {
                    Code = 20000,
                    Success = false
                });
   
            }
            else
            {
                user.Password = dto.NewPassword;
                _service.Update(user);
                return new JsonResult(new
                {
                    Code = 20000,
                    Success = true
                });
            }
        }
        // PUT: api/Userr/5
        [HttpPut]
        public JsonResult Put([FromBody] User User)
        {
   
            _service.Update(User);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public JsonResult Delete(Guid id)
        {
            _service.Delete(id);
            return new JsonResult(new
            {
                code = 20000
            });
        }

    }
}
