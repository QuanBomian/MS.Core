using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AspNetCore.Domain.MenuInfo;
using AspNetCore.Domain.MenuInfo.Dto;
using AspNetCore.Entity;

namespace AspNetCore.Application.MenuInfo
{
    public class MenuAppService : IMenuAppService
    {
        private readonly IMenuDomain _domain;
        public MenuAppService(IMenuDomain domain)
        {
            _domain = domain;
        }
        public void Add(Menu Menu)
        {
            Menu.Id = Guid.NewGuid();
            _domain.Add(Menu);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<Menu>> GetAll()
        {
            return _domain.Get();
        }

        public Menu Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(Menu Menu)
        {
            _domain.Update(Menu);
        }

        public List<Menu> Search(MenuQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
