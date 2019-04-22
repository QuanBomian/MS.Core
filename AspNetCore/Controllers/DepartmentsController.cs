using AspNetCore.Application.DepartmentInfo;
using AspNetCore.Domain.DepartmentInfo.Dto;
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
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentAppService _service;
        public DepartmentsController(IDepartmentAppService service)
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
        public JsonResult GetByCondition([FromQuery] DepartmentQueryDto condition)
        {

            var list = _service.Search(condition);
            return new JsonResult(new
            {
                code = 20000,
                list
            });
        }
        // GET: api/Departmentr/5
        [HttpGet("{id}")]
        public Department Get(Guid id)
        {
            return _service.Get(id);
        }

        // POST: api/Departmentr
        [HttpPost]
        public JsonResult Post([FromBody] Department Department)
        {
            _service.Add(Department);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/Departmentr/5
        [HttpPut]
        public JsonResult Put([FromBody] Department Department)
        {
            _service.Update(Department);
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
