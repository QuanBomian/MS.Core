using System;
using System.Collections.Generic;
using AspNetCore.Domain.DataCategroyInfo.Dto;
using AspNetCore.Entity;
namespace AspNetCore.Domain.DataCategroyInfo
{
    public interface IDataCategroyDomain : IDomain<DataCategroy, Guid>
    {
        List<DataCategroy> Get(DataCategroyQueryDto condition);
    }
}