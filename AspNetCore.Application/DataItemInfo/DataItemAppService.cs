using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.DataItemInfo;
using AspNetCore.Domain.DataItemInfo.Dto;
using AspNetCore.Entity;
using AspNetCore.Entity.Core;

namespace AspNetCore.Application.DataItemInfo
{
    public class DataItemAppService : IDataItemAppService
    {
        private readonly IDataItemDomain _domain;
        public DataItemAppService(IDataItemDomain domain)
        {
            _domain = domain;
        }
        public void Add(DataItem DataItem)
        {
            DataItem.Id = Guid.NewGuid();
            _domain.Add(DataItem);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<DataItem>> GetAll()
        {
            return _domain.Get();
        }

        public DataItem Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(DataItem DataItem)
        {
            _domain.Update(DataItem);
        }

        public List<DataItem> Search(DataItemQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
