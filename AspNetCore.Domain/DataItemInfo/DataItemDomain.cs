using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.DataItemInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;

namespace AspNetCore.Domain.DataItemInfo
{
    public class DataItemDomain : Domain<DataItem, Guid>, IDataItemDomain
    {

        public DataItemDomain(IDataItemRepository repository) : base(repository) { }
        public List<DataItem> Get(DataItemQueryDto queryDto)
        {
            IQueryable<DataItem> query = _repository.Query();
            if (queryDto.ItemCode != null && queryDto.ItemCode != "")
            {
                query = query.Where(DataItem => DataItem.ItemCode.Contains(queryDto.ItemCode));
            }
            if (queryDto.CategroyCode != null && queryDto.CategroyCode != "")
            {
                query = query.Where(DataItem => DataItem.CategroyCode.Contains(queryDto.CategroyCode));
            }
            if (queryDto.Content != null && queryDto.Content != "")
            {
                query = query.Where(DataItem => DataItem.Content.Contains(queryDto.Content));
            }


            return query.ToList();
        }


    }
}
