using AspNetCore.Domain.DepartmentInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.DepartmentInfo
{
    public interface IDepartmentAppService
    {
        Task<List<Department>> GetAll();
        void Update(Department Department);
        void Delete(Guid id);
        void Add(Department Department);
        Department Get(Guid id);
        List<Department> Search(DepartmentQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<Department>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
