using AspNetCore.Application.NonOperatingAssetsInfo;
using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
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
    public class NonOperatingAssetssController : ControllerBase
    {
        private readonly INonOperatingAssetsAppService _service;
        public NonOperatingAssetssController(INonOperatingAssetsAppService service)
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
        public JsonResult GetByCondition([FromQuery] NonOperatingAssetsQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
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
