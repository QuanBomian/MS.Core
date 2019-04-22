using AspNetCore.Application.FamilyInfo;
using AspNetCore.Domain.FamilyInfo.Dto;
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
    public class FamilysController : ControllerBase
    {
        private readonly IFamilyAppService _service;
        public FamilysController(IFamilyAppService service)
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
        public JsonResult GetByCondition([FromQuery] FamilyQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
        }
        // GET: api/Familyr/5
        [HttpGet("{id}")]
        public Family Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Familyr
        [HttpPost]
        public JsonResult Post([FromBody] Family Family)
        {
            _service.Add(Family);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Familyr/5
        [HttpPut]
        public JsonResult Put([FromBody] Family Family)
        {
            _service.Update(Family);
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
