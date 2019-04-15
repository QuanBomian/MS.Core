using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore.Domain.Repository;
using AspNetCore.Entity.Core;
using AspNetCore.Entity;

namespace AspNetCore.Domain.DataCategroyInfo
{
    public class DataCategroyDomain : Domain<DataCategroy, Guid>, IDataCategroyDomain
    {

        public DataCategroyDomain(IDataCategroyRepository repository) : base(repository) { }

    }
}
