using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;

namespace AspNetCore.Domain.Repository
{
    public class DataCategroyRepository : Repository<DataCategroy, Guid>, IDataCategroyRepository
    {
        public DataCategroyRepository(MsContext context) : base(context)
        {
        }
    }
}
