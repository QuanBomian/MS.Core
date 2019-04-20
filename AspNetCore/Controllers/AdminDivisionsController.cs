using AspNetCore.Application.AdminDivisionInfo;
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
    [ApiController]
    [Authorize(Policy = "Permission")]
    public class AdminDivisionsController
    {
        private readonly IAdminDivisionAppService _adminDivisionAppService;
        public AdminDivisionsController(IAdminDivisionAppService adminDivisionAppService)
        {
            _adminDivisionAppService = adminDivisionAppService;
        }
        [HttpGet]
        public JsonResult GetAll() {

            return new JsonResult(new
            {
                code = 20000,
                list = _adminDivisionAppService.GetAdminDivisions()

            });
        }
 
        // GET: api/AdminDivisionr/5
        [HttpGet("{id}")]
        public JsonResult Get(Guid id)
        {
            var item = _adminDivisionAppService.Get(id);
            return new JsonResult(new
            {
                code = 20000,
                item
            });
            
        }

        // POST: api/AdminDivisionr
        [HttpPost]
        public JsonResult Post([FromBody] AdminDivision AdminDivision)
        {
            _adminDivisionAppService.Add(AdminDivision);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // PUT: api/AdminDivisionr/5
        [HttpPut]
        public JsonResult Put([FromBody] AdminDivision AdminDivision)
        {
            _adminDivisionAppService.Update(AdminDivision);
            return new JsonResult(new
            {
                code = 20000
            });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public JsonResult Delete(Guid id)
        {
            _adminDivisionAppService.Delete(id);
            return new JsonResult(new
            {
                code = 20000
            });
        }
    }
}
