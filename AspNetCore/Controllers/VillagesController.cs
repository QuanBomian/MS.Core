using AspNetCore.Application.VillageInfo;
using AspNetCore.Domain.VillageInfo.Dto;
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
    public class VillagesController : ControllerBase
    {
        private readonly IVillageAppService _service;
        public VillagesController(IVillageAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] VillageQueryDto condition)
        {
            if(condition.Address!=null||condition.AreaNumber!=null||condition.ContactPhone!=null
                ||condition.GovernmentLevel!=null||condition.GroupCount!=null||condition.SecretaryName!=null
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
