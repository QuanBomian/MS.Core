using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class VillageRepository : Repository<Village, Guid>, IVillageRepository
    {

        public VillageRepository(MsContext db) : base(db)
        {
        }


    }
}
