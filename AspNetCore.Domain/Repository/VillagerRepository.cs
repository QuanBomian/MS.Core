using System;
using AspNetCore.Entity.Context;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.Repository
{
    public class VillagerRepository : Repository<Villager,Guid>, IVillagerRepository
    {

        public VillagerRepository(MsContext db):base(db)
        {
        }

  
    }
}
