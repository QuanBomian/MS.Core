using AspNetCore.Application.DepartmentInfo;
using AspNetCore.Domain.DepartmentInfo;
using AspNetCore.Domain.DepartmentInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.DepartmentInfo
{
    public class DepartmentAppService : IDepartmentAppService
    {
        private readonly IDepartmentDomain _domain;
        public DepartmentAppService(IDepartmentDomain domain)
        {
            _domain = domain;
        }
        public void Add(Department Department)
        {
            Department.Id = Guid.NewGuid();
            _domain.Add(Department);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Department>> GetAll()
        {
            return _domain.Get();
        }

        public Department Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Department Department)
        {
            _domain.Update(Department);
        }

        public List<Department> Search(DepartmentQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
