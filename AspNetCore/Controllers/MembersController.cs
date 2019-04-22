using AspNetCore.Application.MemberInfo;
using AspNetCore.Domain.MemberInfo.Dto;
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
    public class MembersController : ControllerBase
    {
        private readonly IMemberAppService _service;
        public MembersController(IMemberAppService service)
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
        public JsonResult GetByCondition([FromQuery] MemberQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
        }
        // GET: api/Memberr/5
        [HttpGet("{id}")]
        public Member Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Memberr
        [HttpPost]
        public JsonResult Post([FromBody] Member Member)
        {
            _service.Add(Member);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Memberr/5
        [HttpPut]
        public JsonResult Put([FromBody] Member Member)
        {
            _service.Update(Member);
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
