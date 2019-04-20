using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;
using AspNetCore.Domain.DataCategroyInfo.Dto;

namespace AspNetCore.Domain.DataCategroyInfo
{
    public class DataCategroyDomain : Domain<DataCategroy, Guid>, IDataCategroyDomain
    {

        public DataCategroyDomain(IDataCategroyRepository repository) : base(repository) { }

        public List<DataCategroy> Get(DataCategroyQueryDto condition)
        {
            IQueryable<DataCategroy> query = _repository.Query();
            if (condition.CategroyCode != null && condition.CategroyCode.Trim() != "")
            {
                query = query.Where(DataCategroy => DataCategroy.CategroyCode.Contains(condition.CategroyCode));
            }
            if (condition.CategroyName != null && condition.CategroyName.Trim() != "")
            {
                query = query.Where(DataCategroy => DataCategroy.CategroyName.Contains(condition.CategroyName));
            }
            return query.ToList();
        }
    }
}
