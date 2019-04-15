using System;
using System.Collections.Generic;
using AspNetCore.Domain.DataItemInfo.Dto;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;
namespace AspNetCore.Domain.DataItemInfo
{
    public interface IDataItemDomain : IDomain<DataItem, Guid>
    {
        List<DataItem> Get(DataItemQueryDto queryDto);
    }
}