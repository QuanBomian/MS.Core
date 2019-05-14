using AspNetCore.Application.VillageInfo;
using AspNetCore.Domain.VillageInfo;
using AspNetCore.Domain.VillageInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;
using AspNetCore.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.VillageInfo
{
    public class VillageAppService : IVillageAppService
    {
        private readonly IVillageDomain _domain;
        public VillageAppService(IVillageDomain domain)
        {
            _domain = domain;
        }
        public void Add(Village Village)
        {
            Village.Id = Guid.NewGuid();
            _domain.Add(Village);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Village>> GetAll()
        {
            return _domain.Get();
        }

        public Village Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Village Village)
        {
            _domain.Update(Village);
        }

        public List<Village> Search(VillageQueryDto condition)
        {
            return _domain.Get(condition);
        }
        public async Task<PaginatedList<Village>> GetPaginationAsync(int pageIndex, int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<Village>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
