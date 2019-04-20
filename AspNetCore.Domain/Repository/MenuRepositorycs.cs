using AspNetCore.Entity;
using AspNetCore.Entity.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.Repository
{
    public class MenuRepository : Repository<Menu, Guid>, IMenuRepository
    {
        public MenuRepository(MsContext context) : base(context) { }
    }
}
