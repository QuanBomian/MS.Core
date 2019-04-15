using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;

namespace AspNetCore.Domain.Repository
{
    public class DataItemRepository : Repository<DataItem, Guid>, IDataItemRepository
    {
        public DataItemRepository(MsContext context) : base(context)
        {
        }
    }
}
