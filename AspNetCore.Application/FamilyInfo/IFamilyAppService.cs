using AspNetCore.Domain.FamilyInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.FamilyInfo
{
    public interface IFamilyAppService
    {
        Task<List<Family>> GetAll();
        void Update(Family Family);
        void Delete(Guid id);
        void Add(Family Family);
        Family Get(Guid id);
        List<Family> Search(FamilyQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<Family>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
