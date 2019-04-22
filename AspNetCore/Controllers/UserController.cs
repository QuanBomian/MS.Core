using AspNetCore.Application.UserInfo;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _service;
        public UsersController(IUserAppService service)
        {
            _service = service;
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
