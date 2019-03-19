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

        public UserInfoDto GetUserInfo(string username,string password)
        {
            User u  =_userRepository.Query(user => user.UserName == username).ToList().First();
            if (u.Password != password)
            {
                return new UserInfoDto
                {
                    Success = false
                };
            }

            var userRoles = _userRoleRepository.GetRolesByUserId(u.Id);
            List<string> roles = new List<string>();
            foreach (var usr in userRoles)
            {
                roles.Add(usr.Role.RoleName);
            }

            return new UserInfoDto
            {
                Success = true,
                UserId = u.Id,
                RoleNames = roles
            };
        }
    }
}
