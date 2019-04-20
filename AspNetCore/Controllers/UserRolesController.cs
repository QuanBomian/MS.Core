using AspNetCore.Application.UserRoleInfo;
using AspNetCore.Domain.UserRoleInfo.Dto;
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
    public class UserRolesController : ControllerBase
    {
        private readonly IUserRoleAppService _service;
        public UserRolesController(IUserRoleAppService service)
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
        // GET: api/UserRoler/5
        [HttpGet("{id}")]
        public UserRole Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/UserRoler
        [HttpPost]
        public JsonResult Post([FromBody] UserRole UserRole)
        {
            _service.Add(UserRole);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/UserRoler/5
        [HttpPut("{id}")]
        public JsonResult Put([FromBody] UserRole UserRole)
        {
            _service.Update(UserRole);
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
