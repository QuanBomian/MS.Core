using System;
using AspNetCore.Entity.Core;

namespace AspNetCore.Domain.Repository
{
    public interface IVillagerRepository:IRepository<Villager,Guid>
    {
    }
}