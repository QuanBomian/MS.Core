using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AspNetCore.Domain.Repository;
using AspNetCore.Domain.UserInfo.Dto;
using AspNetCore.Entity;

namespace AspNetCore.Domain.UserInfo
{
    public class UserInfoDomain : IUserInfoDomain
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;

        public UserInfoDomain(IUserRepository userRepository, 
            IUserRoleRepository userRoleRepository)
        {
            _userRoleRepository = userRoleRepository;
  
            _userRepository = userRepository;
        }

        public User GetUserByPassword(string username)
        {
            var user = _userRepository.Query(a => a.UserName == username).First();
            return user;

        }

        public List<string> GetUserInfo(Guid userId)
        {
            var userRoles = _userRoleRepository.GetRolesByUserId(userId);
            List<string> roles = new List<string>();
            foreach (var usr in userRoles)
            {
                roles.Add(usr.Role.RoleName);
            }
            return roles;
           
        }
    }
}
