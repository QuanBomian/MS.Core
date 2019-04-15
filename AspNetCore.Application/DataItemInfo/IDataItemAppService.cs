using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.DataItemInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.DataItemInfo
{
    public interface IDataItemAppService
    {
        Task<List<DataItem>> GetAll();
        void Update(DataItem DataItem);
        void Delete(Guid id);
        void Add(DataItem DataItem);
        DataItem Get(Guid id);
        List<DataItem> Search(DataItemQueryDto condition);
    }
}
