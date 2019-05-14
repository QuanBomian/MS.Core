using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Domain.TownInfo;
using AspNetCore.Domain.TownInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Pagination;

namespace AspNetCore.Application.TownInfo
{
    public class TownAppService : ITownAppService
    {
        private readonly ITownDomain _domain;
        public TownAppService(ITownDomain domain)
        {
            _domain = domain;
        }
        public void Add(Town town)
        {
            town.Id = Guid.NewGuid();
            _domain.Add(town);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Town>> GetAll()
        {
            return _domain.Get();
        }

        public Town Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Town town)
        {
            _domain.Update(town);
        }

        public List<Town> Search(TownQueryDto condition)
        {
            return _domain.Get(condition);
        }
        public async Task<PaginatedList<Town>> GetPaginationAsync(int pageIndex, int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<Town>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
