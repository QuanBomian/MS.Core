using AspNetCore.Application.DataCategroyInfo;
using AspNetCore.Domain.DataCategroyInfo.Dto;
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
    public class DataCategroysController : ControllerBase
    {
        private readonly IDataCategroyAppService _service;
        public DataCategroysController(IDataCategroyAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] DataCategroyQueryDto condition)
        {
            if (condition.CategroyCode ==null && condition.CategroyName ==null)
            {
                var items = await _service.GetAll();
                return new JsonResult(new
                {
                    code = 20000,
                    items
                });
            }
            else
            {
                var list = _service.Search(condition);
                return new JsonResult(new
                {
                    code = 20000,
                    list
                });
            }
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
        [HttpPut]
        public JsonResult Put([FromBody] DataCategroy DataCategroy)
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
