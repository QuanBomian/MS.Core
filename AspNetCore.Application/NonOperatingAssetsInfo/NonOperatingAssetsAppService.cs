using AspNetCore.Application.NonOperatingAssetsInfo;
using AspNetCore.Domain.NonOperatingAssetsInfo;
using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.NonOperatingAssetsInfo
{
    public class NonOperatingAssetsAppService : INonOperatingAssetsAppService
    {
        private readonly INonOperatingAssetsDomain _domain;
        public NonOperatingAssetsAppService(INonOperatingAssetsDomain domain)
        {
            _domain = domain;
        }
        public void Add(NonOperatingAssets NonOperatingAssets)
        {
            NonOperatingAssets.Id = Guid.NewGuid();
            _domain.Add(NonOperatingAssets);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<NonOperatingAssets>> GetAll()
        {
            return _domain.Get();
        }

        public NonOperatingAssets Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(NonOperatingAssets NonOperatingAssets)
        {
            _domain.Update(NonOperatingAssets);
        }

        public List<NonOperatingAssets> Search(NonOperatingAssetsQueryDto condition)
        {
            return _domain.Get(condition);
        }
        public async Task<PaginatedList<NonOperatingAssets>> GetPaginationAsync(int pageIndex, int pageSize)
        {
            var query = _domain.Query();
            return await PaginatedList<NonOperatingAssets>.CreateAsync(query, pageIndex, pageSize);
        }
    }
}
