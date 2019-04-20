using AspNetCore.Domain.MenuInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.MenuInfo
{
    public interface IMenuAppService
    {
        Task<List<Menu>> GetAll();
        void Update(Menu Menu);
        void Delete(Guid id);
        void Add(Menu Menu);
        Menu Get(Guid id);
        List<Menu> Search(MenuQueryDto condition);
    }
}
