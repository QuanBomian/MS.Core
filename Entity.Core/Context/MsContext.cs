using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity.Core;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Entity.Context
{
    public class MsContext: DbContext
    {
        public DbSet<Villager> Villagers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        private static  readonly string connString = "Host=localhost;Port=5432;Database=mstb;Username=postgres;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connString);
         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            var admin = new {Id = Guid.NewGuid(), UserName = "admin", Password = "admin"};
            var user1 = new { Id = Guid.NewGuid(), UserName = "user1", Password = "user1"};
            var user2 = new { Id = Guid.NewGuid(), UserName = "user2", Password = "user2"};
            var user3 = new { Id = Guid.NewGuid(), UserName = "user3", Password = "user3"};
            modelBuilder.Entity<User>().HasData(
               admin,user1,user2,user3
            );
            var roleAdmin = new {Id = Guid.NewGuid(), RoleName = "Admin"};
            var roleClient = new {Id = Guid.NewGuid(), RoleName = "Client"};
            var roleSystem = new {Id = Guid.NewGuid(), RoleName = "System"};
            modelBuilder.Entity<Role>().HasData(
                roleAdmin,roleClient,roleSystem);
            modelBuilder.Entity<UserRole>().HasData(

                new {Id = Guid.NewGuid(), UserId = admin.Id, RoleId = roleAdmin.Id},
                new {Id = Guid.NewGuid(), UserId = user1.Id, RoleId = roleClient.Id},
                new {Id = Guid.NewGuid(), UserId = user2.Id, RoleId = roleClient.Id},
                new {Id = Guid.NewGuid(), UserId = user3.Id, RoleId = roleAdmin.Id},
                new {Id = Guid.NewGuid(),UserId = admin.Id,RoleId = roleSystem.Id}
            );
            

        }
    }
}
