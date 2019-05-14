using AspNetCore.Application.FamilyInfo;
using AspNetCore.Domain.FamilyInfo;
using AspNetCore.Domain.FamilyInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.FamilyInfo
{
    public class FamilyAppService : IFamilyAppService
    {
        private readonly IFamilyDomain _domain;
        public FamilyAppService(IFamilyDomain domain)
        {
            _domain = domain;
        }
        public void Add(Family Family)
        {
            Family.Id = Guid.NewGuid();
            _domain.Add(Family);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Family>> GetAll()
        {
            return _domain.Get();
        }

        public Family Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Family Family)
        {
            _domain.Update(Family);
        }

        public List<Family> Search(FamilyQueryDto condition)
        {
            return _domain.Get(condition);
        }
        public async Task<PaginatedList<Family>> GetPaginationAsync(int pageIndex, int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<Family>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
