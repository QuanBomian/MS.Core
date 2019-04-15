using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class FamilyRepository : Repository<Family, Guid>, IFamilyRepository
    {
        public FamilyRepository(MsContext context) : base(context) { }
    }
}
