using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class TownRepository : Repository<Town, Guid>, ITownRepository
    {
        public TownRepository(MsContext context) : base(context) { }
    }
}
