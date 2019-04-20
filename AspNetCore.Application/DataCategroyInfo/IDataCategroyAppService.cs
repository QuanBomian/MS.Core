using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.DataCategroyInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.DataCategroyInfo
{
    public interface IDataCategroyAppService
    {
        Task<List<DataCategroy>> GetAll();
        void Update(DataCategroy DataCategroy);
        void Delete(Guid id);
        void Add(DataCategroy DataCategroy);
        DataCategroy Get(Guid id);
        List<DataCategroy> Search(DataCategroyQueryDto condition);
    }
}
