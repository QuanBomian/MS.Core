using AspNetCore.Domain.MenuInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Domain.MenuInfo
{
    public interface IMenuDomain : IDomain<Menu, Guid>
    {
        List<Menu> Get(MenuQueryDto condition);
    }
}
