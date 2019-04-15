using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class VillagerGroupRepository : Repository<VillagerGroup, Guid>, IVillagerGroupRepository
    {
        public VillagerGroupRepository(MsContext context) : base(context) { }
    }
}
