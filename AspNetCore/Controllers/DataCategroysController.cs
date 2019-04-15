using AspNetCore.Application.DataCategroyInfo;
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
    public class DataCategroysController : ControllerBase
    {
        private readonly IDataCategroyAppService _service;
        public DataCategroysController(IDataCategroyAppService service)
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
       
        // GET: api/DataCategroyr/5
        [HttpGet("{id}")]
        public DataCategroy Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/DataCategroyr
        [HttpPost]
        public JsonResult Post([FromBody] DataCategroy DataCategroy)
        {
            _service.Add(DataCategroy);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/DataCategroyr/5
        [HttpPut("{id}")]
        public JsonResult Put(Guid id, [FromBody] DataCategroy DataCategroy)
        {
            _service.Update(DataCategroy);
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
