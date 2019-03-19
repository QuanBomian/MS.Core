using System;
using AspNetCore.Entity;
using AspNetCore.Entity.Context;

namespace AspNetCore.Domain.Repository
{
    public class UserRepository:Repository<User,Guid>,IUserRepository
    {
       public UserRepository(MsContext context) : base(context) { }
    }
}
