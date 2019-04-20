using AspNetCore.Domain.MenuInfo.Dto;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetCore.Domain.MenuInfo
{
    public class MenuDomain : Domain<Menu, Guid>, IMenuDomain
    {
        public MenuDomain(IMenuRepository repository) : base(repository) { }

        public List<Menu> Get(MenuQueryDto condition)
        {
            IQueryable<Menu> query = _repository.Query();
            if (condition.RoleName != null && condition.RoleName.Trim() != "")
            {
                query = query.Where(Menu => Menu.RoleName.Contains(condition.RoleName));
            }
            if (condition.Url != null && condition.Url.Trim() != "")
            {
                query = query.Where(Menu => Menu.Url.Contains(condition.Url));
            }
          

            return query.ToList();


        }
    }
}
