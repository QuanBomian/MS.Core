using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.VillagerInfo;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
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

        public async Task<JsonResult> GetAsync([FromQuery] VillagerQueryDto condition)
        {
            if(condition.AnnualIncomeFrom!=null||condition.AnnualIncomeTo!=null||condition.BirthdayFrom!=null
                ||condition.BirthdayTo!=null||condition.Education!=null||condition.Gender!=null||condition.HavingCriminalRecord!=null||
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
