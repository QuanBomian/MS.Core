using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Application.VillagerInformation;
using AspNetCore.Entity.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillagerController : ControllerBase
    {
        private readonly IVillagerAppService _service;

        public VillagerController(IVillagerAppService service)
        {
            _service = service;
        }
        // GET: api/Villager
        [HttpGet]
        public Task<List<Villager>> Get()
        {
            return _service.GetAll();
        }

        // GET: api/Villager/5
        [HttpGet("{id}", Name = "Get")]
        public Villager Get(int id)
        {
            return _service.Get(id);
        }

        // POST: api/Villager
        [HttpPost]
        public void Post([FromBody] Villager villager)
        {
            _service.Add(villager);
        }

        // PUT: api/Villager/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Villager villager)
        {
            _service.Update(villager);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
