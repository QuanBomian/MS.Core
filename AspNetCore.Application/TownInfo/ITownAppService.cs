using AspNetCore.Domain.TownInfo.Dto;
using AspNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.Application.TownInfo
{
    public interface ITownAppService
    {
        Task<List<Town>> GetAll();
        void Update(Town town);
        void Delete(Guid id);
        void Add(Town town);
       Town Get(Guid id);
        List<Town> Search(TownQueryDto condition);
    }
}
