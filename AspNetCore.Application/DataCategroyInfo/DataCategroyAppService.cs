using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AspNetCore.Domain.DataCategroyInfo;
using AspNetCore.Domain.DataCategroyInfo.Dto;
using AspNetCore.Entity;

namespace AspNetCore.Application.DataCategroyInfo
{
    public class DataCategroyAppService : IDataCategroyAppService
    {
        private readonly IDataCategroyDomain _domain;
        public DataCategroyAppService(IDataCategroyDomain domain)
        {
            _domain = domain;
        }
        public void Add(DataCategroy DataCategroy)
        {
            DataCategroy.Id = Guid.NewGuid();
            _domain.Add(DataCategroy);
        }

        public void Delete(Guid id)
        {
            _domain.Delete(id);
        }

        public Task<List<DataCategroy>> GetAll()
        {
            return _domain.Get();
        }

        public DataCategroy Get(Guid id)
        {
            return _domain.GetById(id);
        }

        public void Update(DataCategroy DataCategroy)
        {
            _domain.Update(DataCategroy);
        }

        public List<DataCategroy> Search(DataCategroyQueryDto condition)
        {
            return _domain.Get(condition);
        }
    }
}
