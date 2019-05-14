using AspNetCore.Domain.VillageInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.VillageInfo
{
    public interface IVillageAppService
    {
        Task<List<Village>> GetAll();
        void Update(Village Village);
        void Delete(Guid id);
        void Add(Village Village);
        Village Get(Guid id);
        List<Village> Search(VillageQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<Village>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
