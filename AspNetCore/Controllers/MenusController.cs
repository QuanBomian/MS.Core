using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.MenuInfo;
using AspNetCore.Domain.MenuInfo.Dto;
using AspNetCore.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "Permission")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMenuAppService _service;
        public MenusController(IMenuAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery]MenuQueryDto condition)
        {
            if (condition.RoleName!= null||condition.Url!=null)
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
        // GET: api/Menur/5
        [HttpGet("{id}")]
        public Menu Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Menur
        [HttpPost]
        public JsonResult Post([FromBody] Menu Menu)
        {
            _service.Add(Menu);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Menur/5
        [HttpPut]
        public JsonResult Put([FromBody] Menu Menu)
        {
            _service.Update(Menu);
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