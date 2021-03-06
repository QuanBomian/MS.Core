﻿using AspNetCore.Application.RoleInfo;
using AspNetCore.Domain.RoleInfo.Dto;
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
    public class RolesController : ControllerBase
    {
        private readonly IRoleAppService _service;
        public RolesController(IRoleAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery]RoleQueryDto condition)
        {
            if(condition.RoleName != null)
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
        // GET: api/Roler/5
        [HttpGet("{id}")]
        public Role Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Roler
        [HttpPost]
        public JsonResult Post([FromBody] Role Role)
        {
            _service.Add(Role);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Roler/5
        [HttpPut]
        public JsonResult Put([FromBody] Role Role)
        {
            _service.Update(Role);
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
