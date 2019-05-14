using AspNetCore.Application.Excel;
using AspNetCore.Application.VillageInfo;
using AspNetCore.Domain.VillageInfo.Dto;
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
    public class VillagesController : ControllerBase
    {
        private readonly IVillageAppService _service;
        public VillagesController(IVillageAppService service)
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
        { "VillageName","村名"},
        { "AreaNumber","行政编码"},
        {"HighLevelAreaNumber","上级行政编码" },
        { "GovernmentLevel", "行政级别" },
        {"UrbanRuralClassification","城乡分类" },
        { "SecretaryName","党支部书记姓名"},
        {"VillageHeadName","村委会主任姓名" },
        {"ContactPhone","联系电话" },
        {"GroupCount","下属村民小组数量" }
    };
            var fs = ExcelHelper.GetByteToExportExcel(result, columns, new List<string>(), "Sheet1", "", isProtected);
            return File(fs, "application/vnd.android.package-archive", $"村信息.xlsx");
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] VillageQueryDto condition,int? pageIndex,int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.Address != null || condition.AreaNumber != null || condition.ContactPhone != null
                || condition.GovernmentLevel != null || condition.GroupCount != null || condition.SecretaryName != null
                || condition.UrbanRuralClassification != null || condition.VillageHeadName != null || condition.VillageName != null)
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
        // GET: api/Villager/5
        [HttpGet("{id}")]
        public Village Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Villager
        [HttpPost]
        public JsonResult Post([FromBody] Village Village)
        {
            _service.Add(Village);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Villager/5
        [HttpPut]
        public JsonResult Put([FromBody] Village Village)
        {
            _service.Update(Village);
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
