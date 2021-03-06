﻿using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity;

namespace AspNetCore.Domain.Repository
{
    public interface IUserRoleRepository:IRepository<UserRole,Guid>
    {
        List<UserRole> GetRolesByUserId(Guid userId);
    }
}
