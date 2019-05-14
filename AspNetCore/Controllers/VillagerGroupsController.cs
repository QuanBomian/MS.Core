using AspNetCore.Application.Excel;
using AspNetCore.Application.VillagerGroupInfo;
using AspNetCore.Domain.VillagerGroupInfo.Dto;
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
    public class VillagerGroupsController : ControllerBase
    {
        private readonly IVillagerGroupAppService _service;
        public VillagerGroupsController(IVillagerGroupAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("excel")]
        public async Task<IActionResult> GetExcel(int isProtected = 0)
        {
            var result = await _service.GetAll();
            var columns = new Dictionary<string, string>() {
        { "Id","序号"},
        { "VillagerGroupCode","村民小组编码"},
        { "PrincipalName","负责人姓名"},
        {"PrincipalAddress","负责人家庭住址" },
        { "PrincipalEmail", "负责人电子邮箱" },
        {"PrincipalPhone","负责人联系电话" },
        { "VillageName","所属村名"},
        {"MemberNumber","成员数量" }
       
    };
            var fs = ExcelHelper.GetByteToExportExcel(result, columns, new List<string>(), "Sheet1", "", isProtected);
            return File(fs, "application/vnd.android.package-archive", $"村民小组信息.xlsx");
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] VillagerGroupQueryDto condition, int? pageIndex, int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.MemberNumber != null ||
                condition.PrincipalAddress != null ||
                condition.PrincipalEmail != null ||
                condition.PrincipalPhone != null ||
                condition.VillageGroupCode != null ||
                condition.VillageName != null)
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
        [HttpPut]
        public JsonResult Put([FromBody] VillagerGroup VillagerGroup)
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
