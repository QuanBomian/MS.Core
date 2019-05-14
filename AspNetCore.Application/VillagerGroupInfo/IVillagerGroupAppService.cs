using AspNetCore.Domain.VillagerGroupInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.VillagerGroupInfo
{
    public interface IVillagerGroupAppService
    {
        Task<List<VillagerGroup>> GetAll();
        void Update(VillagerGroup VillagerGroup);
        void Delete(Guid id);
        void Add(VillagerGroup VillagerGroup);
        VillagerGroup Get(Guid id);
        List<VillagerGroup> Search(VillagerGroupQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<VillagerGroup>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
