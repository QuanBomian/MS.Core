using AspNetCore.Application.DataItemInfo;
using AspNetCore.Domain.DataItemInfo.Dto;
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
    public class DataItemsController : ControllerBase
    {
        private readonly IDataItemAppService _service;
        public DataItemsController(IDataItemAppService service)
        {
            _service = service;
        }
        [HttpGet]

        public async Task<JsonResult> GetAsync([FromQuery] DataItemQueryDto condition)
        {
            if (condition.CategroyCode == null&&condition.Content==null&&condition.ItemCode==null&&condition.Key==null)
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
        // GET: api/DataItemr/5
        [HttpGet("{id}")]
        public DataItem Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/DataItemr
        [HttpPost]
        public JsonResult Post([FromBody] DataItem DataItem)
        {
            _service.Add(DataItem);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/DataItemr/5
        [HttpPut("{id}")]
        public JsonResult Put([FromBody] DataItem DataItem)
        {
            _service.Update(DataItem);
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
