using AspNetCore.Application.PartyMemberInfo;
using AspNetCore.Domain.PartyMemberInfo.Dto;
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
    public class PartyMembersController : ControllerBase
    {
        private readonly IPartyMemberAppService _service;
        public PartyMembersController(IPartyMemberAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] PartyMemberQueryDto condition, int? pageIndex, int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.BirthdayFrom != null
                || condition.BirthdayTo != null
                || condition.ContactPhone != null
                || condition.DepartmentCode != null
                || condition.Education != null
                || condition.Gender != null
                || condition.IsFullMember != null
                || condition.PartyMemberName != null
                || condition.PartyPosition != null
                || condition.VillageName != null
                || condition.PartyOrganizationName != null
                || condition.Nationality != null
                || condition.MemberCode != null
                )
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
            else
            {
                var items = await _service.GetPaginationAsync(pageIndex.Value, pageSize.Value);
                return new JsonResult(new
                {
                    code = 20000,
                    items
                });
            }
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
