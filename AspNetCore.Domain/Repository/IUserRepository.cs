using System;
using AspNetCore.Entity;

namespace AspNetCore.Domain.Repository
{
    public interface IUserRepository:IRepository<User,Guid>
    {
    }
}
