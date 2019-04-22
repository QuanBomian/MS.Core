using AspNetCore.Application.PartyMemberInfo;
using AspNetCore.Domain.PartyMemberInfo.Dto;
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
    public class PartyMembersController : ControllerBase
    {
        private readonly IPartyMemberAppService _service;
        public PartyMembersController(IPartyMemberAppService service)
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
        public JsonResult GetByCondition([FromQuery] PartyMemberQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
        }
        // GET: api/PartyMemberr/5
        [HttpGet("{id}")]
        public PartyMember Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/PartyMemberr
        [HttpPost]
        public JsonResult Post([FromBody] PartyMember PartyMember)
        {
            _service.Add(PartyMember);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/PartyMemberr/5
        [HttpPut]
        public JsonResult Put( [FromBody] PartyMember PartyMember)
        {
            _service.Update(PartyMember);
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
