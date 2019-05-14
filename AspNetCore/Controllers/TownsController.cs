using AspNetCore.Application.Excel;
using AspNetCore.Application.TownInfo;
using AspNetCore.Domain.TownInfo.Dto;
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
    public class TownsController:ControllerBase
    {
        private readonly ITownAppService _service;
        public TownsController(ITownAppService service)
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
        { "TownName","乡镇名"},
        { "AreaNumber","行政编码"},
        {"GovernmentLevel","行政级别" },
        { "Address", "办公地址" },
        {"MayorName","镇长姓名" },
        { "SecretaryName","党委书记姓名"},
        {"ChairmanName","人大主席姓名" },
        {"ContactPhone","联系电话" },

    };
            var fs = ExcelHelper.GetByteToExportExcel(result, columns, new List<string>(), "Sheet1", "", isProtected);
            return File(fs, "application/vnd.android.package-archive", $"乡镇信息.xlsx");
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] TownQueryDto condition, int? pageIndex, int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.AreaNumber != null ||
                condition.Address != null ||
                condition.ChairmanName != null ||
                condition.ContactPhone != null ||
                condition.GovernmentLevel != null ||
                condition.MayorName != null ||
                condition.SecretaryName != null ||
                condition.TownName != null)
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
        public Town Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Villager
        [HttpPost]
        public JsonResult Post([FromBody] Town town)
        {
            _service.Add(town);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Villager/5
        [HttpPut]
        public JsonResult Put([FromBody] Town town)
        {
            _service.Update(town);
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
