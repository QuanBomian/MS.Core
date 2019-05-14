using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.VillagerInfo;
using AspNetCore.Domain.VillagerInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Infrastructure.Pagination;

namespace AspNetCore.Application.VillagerInfo
{
    public class VillagerAppService : IVillagerAppService
    {
        private readonly IVillagerDomain _domain;
        public VillagerAppService(IVillagerDomain domain)
        {
            _domain = domain;
        }
        public void Add(Villager villager)
        {
            villager.Id = Guid.NewGuid();
            _domain.Add(villager);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Villager>> GetAll()
        {
            return _domain.Get();
        }

        public Villager Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Villager villager)
        {
            _domain.Update(villager);
        }

        public List<Villager> Search(VillagerQueryDto condition)
        {
            return _domain.Get(condition);
        }

        public async Task<PaginatedList<Villager>> GetPaginationAsync(int pageIndex,int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<Villager>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
