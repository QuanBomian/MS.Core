using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.VillagerInfo
{
    public interface IVillagerAppService
    {
        Task<List<Villager>> GetAll();
        void Update(Villager villager);
        void Delete(Guid id);
        void Add(Villager villager);
        Villager Get(Guid id);
        List<Villager> Search(VillagerQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<Villager>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
