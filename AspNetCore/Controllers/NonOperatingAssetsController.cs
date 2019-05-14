using AspNetCore.Application.NonOperatingAssetsInfo;
using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
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
    public class NonOperatingAssetssController : ControllerBase
    {
        private readonly INonOperatingAssetsAppService _service;
        public NonOperatingAssetssController(INonOperatingAssetsAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] NonOperatingAssetsQueryDto condition, int? pageIndex, int? pageSize)
        {
            if (pageIndex == null || pageSize == null)
            {
                if (condition.LibaryCollectionsNumber != null ||
                condition.LibraryNumber != null ||
                condition.OfficeBuildingArea != null ||
                condition.OfficeBuildingNumber != null ||
                condition.SeniorCitizenCenterArea != null ||
                condition.SeniorCitizenCenterNumber != null
                ||
                condition.ServiceStationNumber != null
                ||
                condition.SportActivityRoomArea != null
                ||
                condition.SportsActivityRoomNumber != null
                ||
                condition.StaffQuarterArea != null
                ||
                condition.StaffQuartersNumber != null
                ||
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
       
        // GET: api/NonOperatingAssetsr/5
        [HttpGet("{id}")]
        public NonOperatingAssets Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/NonOperatingAssetsr
        [HttpPost]
        public JsonResult Post([FromBody] NonOperatingAssets NonOperatingAssets)
        {
            _service.Add(NonOperatingAssets);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/NonOperatingAssetsr/5
        [HttpPut]
        public JsonResult Put([FromBody] NonOperatingAssets NonOperatingAssets)
        {
            _service.Update(NonOperatingAssets);
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
