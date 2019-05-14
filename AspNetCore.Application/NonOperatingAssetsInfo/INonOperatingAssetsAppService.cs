using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.NonOperatingAssetsInfo
{
    public interface INonOperatingAssetsAppService
    {
        Task<List<NonOperatingAssets>> GetAll();
        void Update(NonOperatingAssets NonOperatingAssets);
        void Delete(Guid id);
        void Add(NonOperatingAssets NonOperatingAssets);
        NonOperatingAssets Get(Guid id);
        List<NonOperatingAssets> Search(NonOperatingAssetsQueryDto condition);
        Task<Infrastructure.Pagination.PaginatedList<NonOperatingAssets>> GetPaginationAsync(int pageIndex, int pageSize);
    }
}
