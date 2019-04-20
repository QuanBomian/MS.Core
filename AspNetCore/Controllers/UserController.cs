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

        public async Task<JsonResult> GetAsync()
        {
            var items = await _service.GetAll();
            return new JsonResult(new
            {
                code = 20000,
                items
            });
        }
        [HttpGet]
        [Route("condition")]
        public JsonResult GetByCondition([FromQuery] UserQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
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
        [HttpPut("{id}")]
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
