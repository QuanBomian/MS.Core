using AspNetCore.Application.VillagerGroupInfo;
using AspNetCore.Domain.VillagerGroupInfo.Dto;
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
    public class VillagerGroupsController : ControllerBase
    {
        private readonly IVillagerGroupAppService _service;
        public VillagerGroupsController(IVillagerGroupAppService service)
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
        public JsonResult GetByCondition([FromQuery] VillagerGroupQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
        }
        // GET: api/VillagerGroupr/5
        [HttpGet("{id}")]
        public VillagerGroup Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/VillagerGroupr
        [HttpPost]
        public JsonResult Post([FromBody] VillagerGroup VillagerGroup)
        {
            _service.Add(VillagerGroup);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/VillagerGroupr/5
        [HttpPut("{id}")]
        public JsonResult Put(Guid id, [FromBody] VillagerGroup VillagerGroup)
        {
            _service.Update(VillagerGroup);
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
