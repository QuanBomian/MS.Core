using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.Excel;
using AspNetCore.Application.VillagerInfo;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Infrastructure.Pagination;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "Permission")]
    [ApiController]
    public class VillagersController : ControllerBase
    {
        private readonly IVillagerAppService _service;
   

        public VillagersController(IVillagerAppService service)
        {
            _service = service;
        }
        // GET: api/Villager
        [HttpGet]
        [Route("excel")]
        [AllowAnonymous]
        public async Task<IActionResult> GetExcel(int isProtected=0)
        {
            var result = await _service.GetAll();
            var columns = new Dictionary<string, string>() {
        { "Id","序号"},
        { "Name","姓名"},
        { "Birthday","生日"},
                {"Gender","性别" },
                { "HomeAddress", "家庭住址" },
                {
                    "Education","文化水平" },
                { "AnnualIncome","年收入"
                },
                {"MaritalStatus","婚姻状况" },
                {"HavingIllegalRecord","有无违法记录" },
                {"HavingCriminalRecord","有无犯罪记录" }
    };
            var fs = ExcelHelper.GetByteToExportExcel(result, columns, new List<string>(), "Sheet1", "", isProtected);
            return File(fs, "application/vnd.android.package-archive", $"村民信息.xlsx");
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] VillagerQueryDto condition,int? pageIndex,int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.AnnualIncomeFrom != null || condition.AnnualIncomeTo != null || condition.BirthdayFrom != null
                    || condition.BirthdayTo != null || condition.Education != null || condition.Gender != null || condition.HavingCriminalRecord != null ||
                    condition.HavingIllegalRecord != null || condition.HomeAddress != null || condition.MaritalStatus != null || condition.Name != null)
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

                var items = await _service.GetPaginationAsync(pageIndex.Value,pageSize.Value);
                return new JsonResult(new
                {
                    code = 20000,
                    items
                });
            }
        }

        // GET: api/Villager/5
        [HttpGet("{id}", Name = "Get")]
        public Villager Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Villager
        [HttpPost]
        public JsonResult Post([FromBody] Villager villager)
        {
            _service.Add(villager);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Villager/5
        [HttpPut]
        public JsonResult Put([FromBody] Villager villager)
        {
            _service.Update(villager);
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
