using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity.Core;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Entity.Context
{
    public class MsContext : DbContext
    {
        public DbSet<Villager> Villagers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Town> Towns { get; set; }
        private static readonly string connString = "Host=localhost;Port=5432;Database=mstb;Username=postgres;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            var admin = new { Id = Guid.NewGuid(), UserName = "admin", Password = "admin" };
            var user1 = new { Id = Guid.NewGuid(), UserName = "user1", Password = "user1" };
            var user2 = new { Id = Guid.NewGuid(), UserName = "user2", Password = "user2" };
            var user3 = new { Id = Guid.NewGuid(), UserName = "user3", Password = "user3" };
            modelBuilder.Entity<User>().HasData(
               admin, user1, user2, user3
            );
            var roleAdmin = new { Id = Guid.NewGuid(), RoleName = "Admin" };
            var roleClient = new { Id = Guid.NewGuid(), RoleName = "Client" };
            var roleSystem = new { Id = Guid.NewGuid(), RoleName = "System" };
            modelBuilder.Entity<Role>().HasData(
                roleAdmin, roleClient, roleSystem);
            modelBuilder.Entity<UserRole>().HasData(

                new { Id = Guid.NewGuid(), UserId = admin.Id, RoleId = roleAdmin.Id },
                new { Id = Guid.NewGuid(), UserId = user1.Id, RoleId = roleClient.Id },
                new { Id = Guid.NewGuid(), UserId = user2.Id, RoleId = roleClient.Id },
                new { Id = Guid.NewGuid(), UserId = user3.Id, RoleId = roleAdmin.Id },
                new { Id = Guid.NewGuid(), UserId = admin.Id, RoleId = roleSystem.Id }
            );
            modelBuilder.Entity<Villager>().HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    Name = "张东",
                    Birthday = new DateTime(1984, 4, 12),
                    Gender = "男",
                    HomeAddress = "向阳村3组14号",
                    Education = "高中",
                    AnnualIncome = 20000,
                    MaritalStatus = "已婚",
                    HavingIllegalRecord = false,
                    HavingCriminalRecord = false
                },
                new
                {
                    Id = Guid.NewGuid(),
                    Name = "刘项",
                    Birthday = new DateTime(1972, 3, 1),
                    Gender = "男",
                    HomeAddress = "向阳村5组17号",
                    Education = "初中",
                    AnnualIncome = 17000,
                    MaritalStatus = "已婚",
                    HavingIllegalRecord = false,
                    HavingCriminalRecord = false
                },
                new
                {
                    Id = Guid.NewGuid(),
                    Name = "马伦",
                    Birthday = new DateTime(1990, 2, 7),
                    Gender = "男",
                    HomeAddress = "向阳村1组2号",
                    Education = "本科",
                    AnnualIncome = 50000,
                    MaritalStatus = "未婚",
                    HavingIllegalRecord = false,
                    HavingCriminalRecord = false
                }
            );
            modelBuilder.Entity<Town>().HasData(
                new Town { Id = Guid.NewGuid(),TownName = "昆山市高新区", MayorName = "陆机", SecretaryName = "陆云", ChairmanName = "祖冲之", Address = "前进西路168号", ContactPhone = "0512-53387154" },
                new Town { Id = Guid.NewGuid(), TownName = "昆山开发区", MayorName = "逢建德", SecretaryName = "匡俊智", ChairmanName = "邢栋祥", Address = "前进东路", ContactPhone = "0512-32416432" },
                new Town { Id = Guid.NewGuid(),TownName="昆山花桥经济开发区",MayorName= "王班",SecretaryName="吴启河",ChairmanName= "武财章",Address= "花溪路358号",ContactPhone="0512-34872987" },
                new Town { Id = Guid.NewGuid(),TownName="张浦镇",MayorName= "武财章",SecretaryName= "李泰桓",ContactPhone="0521-84729179",ChairmanName= "冯崇霆",Address= "宝觉街与茶风街交叉口北50米" },
                new Town { Id = Guid.NewGuid(),TownName="周市镇",MayorName= "刘赫伯",SecretaryName= "蒋信迟",ChairmanName= "成梦昆",Address= "华杨路188号",ContactPhone="0512-34813245" },
                new Town { Id=Guid.NewGuid(),TownName="陆家镇",MayorName= "梁灶慈",SecretaryName= "刘群胜",ChairmanName= "李迪尉",Address= "菉溪路22号" ,ContactPhone="0512-38274812"},
             new Town { Id= Guid.NewGuid(),TownName="巴城镇",MayorName= "李迪尉",SecretaryName= "钟开桦",ContactPhone="0521-76421843",ChairmanName= "周伟",Address= "新澄路918号" },
             new Town { Id=Guid.NewGuid(),TownName="千灯镇",MayorName= "张弥成",SecretaryName= "时可北",ChairmanName= "林修胜",Address= "炎东路",ContactPhone="0512-28413451" },
             new Town { Id=Guid.NewGuid(),TownName="淀山湖镇",MayorName= "冯便磊",SecretaryName= "颜尚冲",ChairmanName= "常般业",Address= "府前路78号",ContactPhone="0512-83497432" },
             new Town { Id=Guid.NewGuid(),TownName="周庄镇",MayorName= "王翱桦",SecretaryName= "江衷力",ContactPhone="0521-42124521",Address= "淀南路100号",ChairmanName= "陆先" },
             new Town { Id=Guid.NewGuid(),TownName="锦溪镇",MayorName= "倪御奋",SecretaryName= "姬道生",ChairmanName= "邹鉴夕",Address= "普庆路1号",ContactPhone="0521-32188912" });

        }
    }
}
