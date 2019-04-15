using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class NonOperatingAssetsRepository : Repository<NonOperatingAssets, Guid>, INonOperatingAssetsRepository
    {
        public NonOperatingAssetsRepository(MsContext context) : base(context) { }
    }
}
