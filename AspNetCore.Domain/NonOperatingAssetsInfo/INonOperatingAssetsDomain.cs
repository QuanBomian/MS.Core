using AspNetCore.Domain.NonOperatingAssetsInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.NonOperatingAssetsInfo
{
    public interface INonOperatingAssetsDomain : IDomain<NonOperatingAssets, Guid>
    {
        List<NonOperatingAssets> Get(NonOperatingAssetsQueryDto queryDto);
    }
}
