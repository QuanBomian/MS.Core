using System;
using System.Collections.Generic;
using System.Text;
using AspNetCore.Entity.Core;
using AspNetCore.Infrastructure.Secret;
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

        public DbSet<Village> Villages { get; set; }

        public DbSet<VillagerGroup> VillagerGroups { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Family> Families { get; set; }

        public DbSet<NonOperatingAssets> NonOperatingAssets { get; set; }

        public DbSet<PartyMember> PartyMembers { get; set; }

        public DbSet<AdminDivision> AdminDivisions { get; set; }

        public DbSet<DataCategroy> DataCategroys { get; set; }

        public DbSet<DataItem> DataItems { get; set; }
        private static readonly string connString = "Host=localhost;Port=5432;Database=mstb;Username=postgres;Password=12345";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connString);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp");
            #region 用户
            var admin = new { Id = Guid.NewGuid(), UserName = "admin", Password = SecretHelper.GenerateHashSecret("admin") };
            var user1 = new { Id = Guid.NewGuid(), UserName = "user1", Password = SecretHelper.GenerateHashSecret("user1") };
            var user2 = new { Id = Guid.NewGuid(), UserName = "user2", Password = SecretHelper.GenerateHashSecret("user2") };
            var user3 = new { Id = Guid.NewGuid(), UserName = "user3", Password = SecretHelper.GenerateHashSecret("user3") };
            modelBuilder.Entity<User>().HasData(
               admin, user1, user2, user3
            );
            #endregion
            #region 角色
            var roleAdmin = new { Id = Guid.NewGuid(), RoleName = "Admin" };
            var roleClient = new { Id = Guid.NewGuid(), RoleName = "Client" };
            var roleSystem = new { Id = Guid.NewGuid(), RoleName = "System" };
            modelBuilder.Entity<Role>().HasData(
                roleAdmin, roleClient, roleSystem);
            #endregion
            #region 用户角色表
            modelBuilder.Entity<UserRole>().HasData(

                new { Id = Guid.NewGuid(), UserId = admin.Id, RoleId = roleAdmin.Id },
                new { Id = Guid.NewGuid(), UserId = user1.Id, RoleId = roleClient.Id },
                new { Id = Guid.NewGuid(), UserId = user2.Id, RoleId = roleClient.Id },
                new { Id = Guid.NewGuid(), UserId = user3.Id, RoleId = roleAdmin.Id },
                new { Id = Guid.NewGuid(), UserId = admin.Id, RoleId = roleSystem.Id }
            );
            #endregion
            #region 村民
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
            #endregion

            #region 行政规划
            modelBuilder.Entity<AdminDivision>().HasData(
                new AdminDivision { AreaNumber = "320583000000", HighLevelAreaNumber = "", GovernmentName = "昆山市", GovernmentLevel = 3, VillageNumber = 10, VillageGroupNumber = 2205, CountyNumber = 0, Id = Guid.NewGuid() },
                new AdminDivision{
                AreaNumber="320583102000",
                HighLevelAreaNumber="320583000000",
                GovernmentLevel = 4,
                GovernmentName="周市镇",
                TownNumber=0,
                VillageNumber=29,
                VillageGroupNumber=240,
                CountyNumber=0,
                Id = Guid.NewGuid()
                },
                new AdminDivision
                {
                    TownNumber = 12,
                    AreaNumber = "320583400000",
                    HighLevelAreaNumber = "320583000000",
                GovernmentLevel = 4,
                    GovernmentName = "开发区",
                    VillageNumber = 7,
                    VillageGroupNumber = 312,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()

                }
                ,
                new AdminDivision
                {
                    TownNumber =0,
                    AreaNumber = "320583104000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "花桥镇",
                    VillageNumber = 13,
                    VillageGroupNumber = 123,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()

                }
                ,
                new AdminDivision
                {
                    TownNumber =0,
                    AreaNumber = "320583106000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "张浦镇",
                    VillageNumber = 12,
                    VillageGroupNumber = 221,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()

                }
                ,
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583103000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "陆家镇",
                    VillageNumber = 13,
                    VillageGroupNumber = 231,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()

                },
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583101000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "巴城镇",
                    VillageNumber = 13,
                    VillageGroupNumber = 216,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()
                },
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583108000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "千灯镇",
                    VillageNumber = 41,
                    VillageGroupNumber = 213,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()
                },
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583105000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "淀山湖镇",
                    VillageNumber = 11,
                    VillageGroupNumber = 173,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()
                },
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583107000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "周庄镇",
                    VillageNumber = 31,
                    VillageGroupNumber = 123,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()
                },
                new AdminDivision
                {
                    TownNumber = 0,
                    AreaNumber = "320583109000",
                    HighLevelAreaNumber = "320583000000",
                    GovernmentLevel = 4,
                    GovernmentName = "锦溪镇",
                    VillageNumber = 22,
                    VillageGroupNumber = 256,
                    CountyNumber = 0,
                    Id = Guid.NewGuid()
                },

                new AdminDivision
                {
                    TownNumber = 0,
                    Id = Guid.NewGuid(),
                    GovernmentName = "张浦社区",
                    HighLevelAreaNumber = "320583106000",
                    AreaNumber = "320583106001",
                    GovernmentLevel = 5,
                    VillageGroupNumber = 12,
                    CountyNumber=0,
                    VillageNumber=0,
                },
                new AdminDivision
                {
                    TownNumber = 0,
                    Id = Guid.NewGuid(),
                    GovernmentName = "花园社区",
                    HighLevelAreaNumber = "320583106000",
                    AreaNumber = "320583106002",
                    GovernmentLevel = 5,
                    VillageGroupNumber = 12,
                    CountyNumber = 0,
                    VillageNumber = 0,

                },
                 new AdminDivision
                 {
                     TownNumber = 0,
                     Id = Guid.NewGuid(),
                     GovernmentName = "振苏社区",
                     HighLevelAreaNumber = "320583106000",
                     AreaNumber = "320583106003",
                     GovernmentLevel = 5,
                     VillageGroupNumber = 12,
                     CountyNumber = 0,
                     VillageNumber = 0,
                 },
                  new AdminDivision
                  {
                      TownNumber = 0,
                      Id = Guid.NewGuid(),
                      GovernmentName = "南港社区",
                      HighLevelAreaNumber = "320583106000",
                      AreaNumber = "320583106004",
                      GovernmentLevel = 5,
                      VillageGroupNumber = 12,
                      CountyNumber = 0,
                      VillageNumber = 0,
                  }
                );
            #endregion
            #region 镇
            modelBuilder.Entity<Town>().HasData(
             new Town { Id = Guid.NewGuid(),TownName = "周市镇", AreaNumber = "320583102000",GovernmentLevel=4, MayorName = "陆机", SecretaryName = "陆云", ChairmanName = "祖冲之", Address = "前进西路168号", ContactPhone = "0512-57621053" },
             new Town { Id = Guid.NewGuid(), TownName = "开发区", AreaNumber = "320583400000", GovernmentLevel = 4, MayorName = "逢建德", SecretaryName = "匡俊智", ChairmanName = "邢栋祥", Address = "前进东路", ContactPhone = "0512-57329416" },
             new Town { Id = Guid.NewGuid(),TownName="花桥镇", AreaNumber = "320583104000", GovernmentLevel = 4, MayorName = "王班",SecretaryName="吴启河",ChairmanName= "武财章",Address= "花溪路358号",ContactPhone="0512-57698733" },
             new Town { Id = Guid.NewGuid(),TownName="张浦镇",AreaNumber= "320583106000", GovernmentLevel = 4, MayorName = "刘赫伯",SecretaryName= "蒋信迟",ChairmanName= "成梦昆",Address= "华杨路188号",ContactPhone="0512-57452503" },
             new Town { Id=Guid.NewGuid(),TownName="陆家镇", AreaNumber = "	320583103000", GovernmentLevel = 4, MayorName = "梁灶慈",SecretaryName= "刘群胜",ChairmanName= "李迪尉",Address= "菉溪路22号" ,ContactPhone="0512-57671003"},
             new Town { Id= Guid.NewGuid(),TownName="巴城镇",AreaNumber= "320583101000", GovernmentLevel = 4, MayorName = "李迪尉",SecretaryName= "钟开桦",ContactPhone="0521-57656330",ChairmanName= "周伟",Address= "新澄路918号" },
             new Town { Id=Guid.NewGuid(),TownName="千灯镇", AreaNumber = "320583108000", GovernmentLevel = 4, MayorName = "张弥成",SecretaryName= "时可北",ChairmanName= "林修胜",Address= "炎东路",ContactPhone="0512-36620396" },
             new Town { Id=Guid.NewGuid(),TownName="淀山湖镇", AreaNumber = "320583105000", GovernmentLevel = 4, MayorName = "冯便磊",SecretaryName= "颜尚冲",ChairmanName= "常般业",Address= "府前路78号",ContactPhone="0512-57488358" },
             new Town { Id=Guid.NewGuid(),TownName="周庄镇", AreaNumber = "320583107000", GovernmentLevel = 4, MayorName = "王翱桦",SecretaryName= "江衷力",ContactPhone="0521-57211236",Address= "淀南路100号",ChairmanName= "陆先" },
             new Town { Id=Guid.NewGuid(),TownName="锦溪镇", AreaNumber = "320583109000", GovernmentLevel = 4, MayorName = "倪御奋",SecretaryName= "姬道生",ChairmanName= "邹鉴夕",Address= "普庆路1号",ContactPhone="0521-57231290" });
            #endregion

            #region 村
            modelBuilder.Entity<Village>().HasData(
                new Village { Id=Guid.NewGuid(),VillageName="张浦社区",HighLevelAreaNumber= "320583106000", AreaNumber="320583106001", GovernmentLevel=5, UrbanRuralClassification=111,VillageHeadName= "赵乐欣", SecretaryName= "尹乐和", Address= "京东路469号", GroupCount=12,ContactPhone="0512-57441175"},
                new Village { Id = Guid.NewGuid(), VillageName = "花园社区", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106002", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "杜向阳", SecretaryName = "汤振海", Address = "花苑路与京东路交叉口西侧", GroupCount = 26, ContactPhone = "0512-36863123" },
                new Village { Id = Guid.NewGuid(), VillageName ="振苏社区", HighLevelAreaNumber = "320583106000", AreaNumber ="320583106003", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "崔泰宁", SecretaryName = "廖景天", Address = "振苏六村", GroupCount =null, ContactPhone = "0512-55270465" },
                new Village { Id = Guid.NewGuid(), VillageName ="南港社区", HighLevelAreaNumber = "320583106000", AreaNumber ="320583106004", GovernmentLevel = 5, UrbanRuralClassification = 121, VillageHeadName = "尹和蔼", SecretaryName = "阎乐池", Address = "震阳路126号", GroupCount =null, ContactPhone = "0512-57428835" },
                new Village { Id = Guid.NewGuid(), VillageName ="大市社区", HighLevelAreaNumber = "320583106000", AreaNumber ="320583106005", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "薛兴为", SecretaryName = "许宏畅", Address = "淞沪西路36号", GroupCount =null, ContactPhone = "0512-57256550" },
                new Village { Id = Guid.NewGuid(), VillageName ="新巷社区", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106006", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "王康胜", SecretaryName = "孔浩思", Address = "俱巷路894号", GroupCount =null, ContactPhone = "0512-36691258" },
                new Village { Id = Guid.NewGuid(), VillageName ="新吴社区", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106007", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "石欣德", SecretaryName = "吴俊晤", Address = "商秧路178号", GroupCount = 26, ContactPhone = "0512-55272500" },
                new Village { Id = Guid.NewGuid(), VillageName = "大直社区", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106008", GovernmentLevel = 5, UrbanRuralClassification = 112, VillageHeadName = "吕勇男", SecretaryName = "梁奇希", Address = "大直路504号", GroupCount = 23, ContactPhone = "0512-55272500" },
                new Village { Id = Guid.NewGuid(), VillageName = "周巷社区", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106009", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "吴凯凯", SecretaryName = "姜永昌", Address = "周巷路", GroupCount = 40, ContactPhone = "0512-57294577" },
                new Village { Id = Guid.NewGuid(), VillageName ="亲和社区", HighLevelAreaNumber = "320583106000", AreaNumber ="320583106012", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "汤烨磊", SecretaryName = "龙澔", Address = "京东路588号", GroupCount = null, ContactPhone = "0512-57883298" },
                new Village { Id = Guid.NewGuid(), VillageName ="锦和社区", HighLevelAreaNumber = "320583106000", AreaNumber ="320583106013", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "吕尊", SecretaryName = "李段", Address = "京东路731号", GroupCount = null, ContactPhone = "0512-57278938" },
                new Village { Id = Guid.NewGuid(), VillageName ="金华村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106200", GovernmentLevel = 5, UrbanRuralClassification = 112, VillageHeadName = "龙昊焱", SecretaryName = "宋翰学", Address = "金华路1号", GroupCount = 26, ContactPhone = "0512-57293702" },
                
                
                new Village { Id = Guid.NewGuid(), VillageName ="七桥村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106204", GovernmentLevel = 5, UrbanRuralClassification = 112, VillageHeadName = "吴咏德", SecretaryName = "汤明亮", Address = "商鞅路1号", GroupCount = 20, ContactPhone = "0512-50310612" },
                new Village { Id = Guid.NewGuid(), VillageName ="赵陵村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106205", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "程飞虎", SecretaryName = "邹俊雄", Address = "机场路与兴陵路交叉口往南200米", GroupCount = 27, ContactPhone = "0512-57441476" },
                new Village { Id = Guid.NewGuid(), VillageName ="吴加村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106206", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "龚炎彬", SecretaryName = "丁弘亮", Address = "川浩路22号", GroupCount = null, ContactPhone = "0512-57441101" },
                new Village { Id = Guid.NewGuid(), VillageName ="三家村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106207", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "陈浦和", SecretaryName = "史光临", Address = "港浦东路8号", GroupCount = 33, ContactPhone = "0512-5736863220" },
                
                new Village { Id = Guid.NewGuid(), VillageName ="新塘村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106209", GovernmentLevel = 5, UrbanRuralClassification = 111, VillageHeadName = "萧泰河", SecretaryName = "韩华藏", Address = "盛巷花园门卫北侧", GroupCount = 20, ContactPhone = "0512-57441616" },
                new Village { Id = Guid.NewGuid(), VillageName ="星金村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106210", GovernmentLevel = 5, UrbanRuralClassification = 122, VillageHeadName = "冯鹏赋", SecretaryName = "贺博艺", Address = "震阳路与双娄路交叉口", GroupCount = 35, ContactPhone = "0512-57421150" },
                new Village { Id = Guid.NewGuid(), VillageName = "新龙村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106211", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "谭睿诚", SecretaryName = "孙明杰", Address = "陈邱家浜58号", GroupCount = 44, ContactPhone = "0512-50331469" },
                new Village { Id = Guid.NewGuid(), VillageName ="白米村", HighLevelAreaNumber = "320583106000", AreaNumber= "320583106212", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "萧波峻", SecretaryName = "万安怡", Address = "建林路往北到底向西100米", GroupCount =null, ContactPhone = "0512-57120550" },
                new Village { Id = Guid.NewGuid(), VillageName ="林庄村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106214", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "冯兴庆", SecretaryName = "蒋英卓", Address = "南港文体站", GroupCount =28, ContactPhone = "0512-57428327" }
                ,
                new Village { Id = Guid.NewGuid(), VillageName ="安头村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106215", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "史意蕴", SecretaryName = "郝嘉慕", Address = "安头村公交站台往南60米处", GroupCount =25, ContactPhone = "0512-57428927" },
                new Village { Id = Guid.NewGuid(), VillageName ="姜杭村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106219", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "许高岑", SecretaryName = "漕文彦", Address = "江浦南路与C325交叉处", GroupCount =23, ContactPhone = "0512-57272133" },
                new Village { Id = Guid.NewGuid(), VillageName ="尚明甸村", HighLevelAreaNumber = "320583106000", AreaNumber= "320583106220", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "蒋嘉许", SecretaryName = "汤英耀", Address = "长江南路东侧与锦溪北交界", GroupCount =21, ContactPhone = "0512-57256590" },
                new Village { Id = Guid.NewGuid(), VillageName ="南姚村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106221", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "谢高义", SecretaryName = "杨成仁", Address = "姚家港北首", GroupCount =22, ContactPhone = "0512-57117756" },
                new Village { Id = Guid.NewGuid(), VillageName ="大市村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106226", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "金和怡", SecretaryName = "顾绍祺", Address = "淞沪西路与江浦南路交叉口", GroupCount =49, ContactPhone = "0512-57255236" },
                new Village { Id = Guid.NewGuid(), VillageName ="南吉山村", HighLevelAreaNumber = "320583106000", AreaNumber = "320583106227", GovernmentLevel = 5, UrbanRuralClassification = 220, VillageHeadName = "顾飞羽", SecretaryName = "朱嘉石", Address = "淞沪东路12号", GroupCount =null, ContactPhone = "0512-57251131" }
            


                   );
            #endregion

            #region 村民小组
            modelBuilder.Entity<VillagerGroup>().HasData(
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "001",
                    PrincipalName= "吴雪峰",
                    PrincipalPhone="0512-57841234",
                    PrincipalAddress= "张浦镇望江新村6幢206室",
                    PrincipalEmail="wuxuefei@kszpwz.gov.cn",
                    VillageName= "南港社区",
                    MemberNumber = 356
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "002",
                    PrincipalName= "方季同",
                    PrincipalAddress= "张浦镇富都新村3幢204室",
                    PrincipalEmail="fangjitong@kszpfd.gov.cn",
                    VillageName="南港社区",
                    MemberNumber = 412
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "003",
                    PrincipalName= "蔡高",
                    PrincipalAddress= "张浦镇茶风新村1幢206室",
                    PrincipalEmail="caogao@kszpcf.gov.cn",
                    VillageName="花园社区",
                    MemberNumber= 532
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "004",
                    PrincipalName= "常高翰",
                    PrincipalAddress = "张浦镇富仁小区5幢102室",
                    PrincipalEmail="changgaohan@kszpfr.gov.cn",
                    VillageName= "大市社区",
                    MemberNumber=253
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "005",
                    PrincipalName= "钱阳成",
                    PrincipalAddress= "张浦镇风和日丽5幢1102室",
                    PrincipalEmail="qianyancheng@kszpfhrl.gov.cn",
                    VillageName= "南港社区",
                    MemberNumber = 512
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "006",
                    PrincipalName= "孔志文",
                    PrincipalAddress= "张浦镇枫情佳苑3幢306室",
                    PrincipalEmail="kongzhiwen@kszpfqjy.gov.cn",
                    VillageName= "新吴社区",
                    MemberNumber=567
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode = "007",
                    PrincipalName= "胡浩壤",
                    PrincipalAddress= "张浦镇张浦村14号",
                    PrincipalEmail="huhaorang@kszpzp.gov.cn",
                    VillageName="张浦社区",
                    MemberNumber=476
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode ="008",
                    PrincipalName= "薛修贤",
                    PrincipalAddress="张浦镇张浦村142号",
                    PrincipalEmail="xuexiuxian@kszpzp.gov.cn",
                    VillageName="张浦社区",
                    MemberNumber=345
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode ="009",
                    PrincipalName= "何立人",
                    PrincipalAddress= "张浦镇银鹿新城3幢802室",
                    PrincipalEmail ="heliren@kszpylxc.gov.cn",
                    VillageName="张浦社区",
                    MemberNumber=452
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode ="010",
                    PrincipalName= "钟俊德",
                    PrincipalAddress= "张浦镇牡丹苑7幢502",
                    PrincipalEmail="zhongjunde@kszpmdy.gov.cn",
                    VillageName= "周巷社区",
                    MemberNumber=662
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode ="011",
                    PrincipalName= "贾天纵",
                    PrincipalAddress= "张浦镇江南春堤14号",
                    PrincipalEmail="jiatianzong@kszpjnkd.gov.cn",
                    VillageName= "新巷社区",
                    MemberNumber=341
                },
                new VillagerGroup
                {
                    Id = Guid.NewGuid(),
                    VillageGroupCode ="012",
                    PrincipalName= "段学海",
                    PrincipalAddress= "张浦镇安居小区24号",
                    PrincipalEmail="duanxuehai@kszpanxq.gov.cn",
                    VillageName= "大市社区",
                    MemberNumber=543
                }
                );
            #endregion

            #region 组织机构
            modelBuilder.Entity<Department>().HasData(
                new Department {
                    Id = Guid.NewGuid(),
                    DepartmentCode = "001",
                    DepartmentName= "张浦社区党支部委员会",
                    Address= "京东路469号",
                    PrincipalName= "郑兴国",
                    ContactPhone="0512-57623451",
                    Fax="0512-54123412",
                    Email="zhenxinguo@kszpzp.gov.cn",
                    Notes=""

                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    DepartmentCode = "002",
                    DepartmentName= "张浦社区居民委员会",
                    Address= "京东路469号",
                    PrincipalName= "陈乐成",
                    ContactPhone="0512-58289432",
                    Fax="0512-59283414",
                    Email="chenlecheng@kszpzp.gov.cn",
                    Notes="临时兼任"
                },
                new Department
                {
                    Id = Guid.NewGuid(),
                    DepartmentCode ="003",
                    DepartmentName= "花园社区党支部委员会",
                    Address= "花苑路与京东路交叉口西侧",
                    PrincipalName= "许高义",
                    ContactPhone="0512-54128123",
                    Fax="0512-564178314",
                    Email="xugaoyi@kszpzp.gov.cn"
                }
                    );
            #endregion

            #region 人员
            modelBuilder.Entity<Member>().HasData(
                new Member
                {
                    Id = Guid.NewGuid(),
                    MemberCode ="002000",
                    MemberName= "陈乐成",
                    DepartmentCode="002",
                    HomeAddress="张浦镇江北新村14号",
                    Gender="男",
                    Nationality="汉族",
                    IdCardNumber= "320583197407056857",
                    Position="主任",
                    PoliticalStatus="中共党员",
                    Birthday=new DateTime(1974,7,5),
                    Education="本科",
                    Status="在职",
                    EntryTime= new DateTime(2007,2,4),
                    LengthOfService="12年",
                    MaritalStatus="已婚"
                },
                new Member
                {
                    Id = Guid.NewGuid(),
                    MemberCode = "002001",
                    MemberName = "姜兴安",
                    DepartmentCode = "002",
                    HomeAddress = "张浦镇浦江北新村112号",
                    Gender = "男",
                    Nationality = "汉族",
                    IdCardNumber = "320583197707087692",
                    Position = "副主任",
                    PoliticalStatus = "中共党员",
                    Birthday = new DateTime(1977, 7, 8),
                    Education = "本科",
                    Status = "在职",
                    EntryTime = new DateTime(2002, 4, 1),
                    LengthOfService = "17年",
                    MaritalStatus="已婚"
                },
                new Member
                {
                    Id = Guid.NewGuid(),
                    MemberCode = "002002",
                    MemberName = "于君昊",
                    DepartmentCode = "002",
                    HomeAddress = "张浦镇江北新村56号",
                    Gender = "男", Nationality = "汉族",
                    IdCardNumber = "320583198504178937",
                    Position = "治调委员",
                    PoliticalStatus = "中共党员",
                    Birthday = new DateTime(1985, 4, 17),
                    Education = "高中",
                    Status = "在职",
                    EntryTime = new DateTime(2010, 3, 4),
                    LengthOfService = "9年",
                    MaritalStatus="丧偶"
                  
                },
                new Member
                {
                    Id = Guid.NewGuid(),
                    MemberCode = "002003",
                    MemberName = "康志国",
                    DepartmentCode = "002",
                    HomeAddress = "张浦镇江北新村12号",
                    Gender = "男", Nationality = "汉族",
                    IdCardNumber = "320583197910154878",
                    Position = "财经委员",
                    PoliticalStatus = "群众",
                    Birthday = new DateTime(1979, 10, 15),
                    Education="硕士研究生",
                    Status="在职",
                    EntryTime=new DateTime(2005,7,12),
                    LengthOfService="14年",
                    MaritalStatus="离异",
                },
                new Member
                {
                    Id = Guid.NewGuid(),
                    MemberCode ="002004",
                    MemberName= "赵陈红",
                    DepartmentCode="002",
                    HomeAddress="张浦镇江北新村17号",
                    Gender="女",Nationality="汉族",
                    IdCardNumber= "320583198704187965",
                    PoliticalStatus="群众",
                    Position= "妇女计生委员",
                    Birthday=new DateTime(1987,4,18),
                    Education="本科",
                    Status="在职",
                    EntryTime=new DateTime(2007,1,4),
                    LengthOfService = "12年",
                    MaritalStatus="已婚"
                }
                
                );
            #endregion

            #region 党员
            modelBuilder.Entity<PartyMember>().HasData(
                new PartyMember
                {
                    Id = Guid.NewGuid(),
                    MemberCode="001000",
                    PartyMemberName= "陈乐成",
                    Gender="男",
                    Nationality="汉族",
                    Education="本科",
                    Birthday=new DateTime(1974,7,5),
                    VillageName="张浦社区",
                    DepartmentCode="001",
                    PartyOrganizationName= "张浦社区党支部委员会",
                    PartyPosition="无",
                    ContactPhone="13057134712",
                    IsFullMember = true,
                }
                );
            #endregion

            #region 非经营性资产
            modelBuilder.Entity<NonOperatingAssets>().HasData(
                new NonOperatingAssets
                {
                    Id = Guid.NewGuid(),
                    VillageName="张浦社区",
                    OfficeBuildingNumber = 1,
                    OfficeBuildingArea = 105,
                    ServiceStationNumber = 4,
                    SeniorCitizenCenterNumber = 1,
                    SeniorCitizenCenterArea = 450,
                    SportsActivityRoomNumber = 2,
                    SportActivityRoomArea = 1000,
                    StaffQuartersNumber = 1,
                    StaffQuarterArea = 1000,
                    LibraryNumber =1,
                    LibaryCollectionsNumber = 3000
                },
                new NonOperatingAssets
                {
                    Id = Guid.NewGuid(),
                    VillageName = "花园社区",
                    OfficeBuildingNumber = 1,
                    OfficeBuildingArea = 172,
                    ServiceStationNumber = 2,
                    SeniorCitizenCenterNumber = 1,
                    SeniorCitizenCenterArea = 380,
                    SportsActivityRoomNumber = 1,
                    SportActivityRoomArea = 800,
                    StaffQuartersNumber = 1,
                    StaffQuarterArea = 1200,
                    LibraryNumber = 1,
                    LibaryCollectionsNumber = 2500

                },
                new NonOperatingAssets
                {
                    Id = Guid.NewGuid(),
                    VillageName = "振苏社区",
                    OfficeBuildingNumber = 2,
                    OfficeBuildingArea = 250,
                    ServiceStationNumber = 1,
                    SeniorCitizenCenterNumber = 2,
                    SeniorCitizenCenterArea = 700,
                    SportsActivityRoomNumber = 3,
                    SportActivityRoomArea = 1500,
                    StaffQuartersNumber = 2,
                    StaffQuarterArea = 2000,
                    LibraryNumber = 1,
                    LibaryCollectionsNumber =5000
                }
                
                
                );

            #endregion

            #region 家庭信息

            modelBuilder.Entity<Family>().HasData(
                new Family {
                    Id = Guid.NewGuid(),
                    FamilyCode = "001000",
                    Householder = "秦博厚",
                    PeopleNumber = 5,
                    AccountCharacter = "非农业",
                    VillageGroupCode = "001",
                    AverageAnnualIncome = 5000,
                    HousingArea = 104.2f,
                    AverageHousingArea = 20.84f,
                    IsLowIncome = false,
                    IsPoor = false
                }
                );
            #endregion
            #region
            modelBuilder.Entity<DataCategroy>().HasData(
                new DataCategroy
                {
                    Id=Guid.NewGuid(),
                    CategroyCode ="001",
                    CategroyName= "城乡分类"
                },
                new DataCategroy
                {
                    Id = Guid.NewGuid(),
                    CategroyCode ="002",
                    CategroyName="行政级别",
                },
                new DataCategroy
                {
                    Id = Guid.NewGuid(),
                    CategroyCode ="003",
                    CategroyName= "政治面貌"

                });
            #endregion

            #region 数据字典
            modelBuilder.Entity<DataItem>().HasData(
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "001",
                    CategroyCode ="001",
                    Content="主城区"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "002",
                    CategroyCode ="001",
                    Content="城乡结合区"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "003",
                    CategroyCode ="001",
                    Content="镇中心区"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "004",
                    CategroyCode ="001",
                    Content="特殊区域"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "005",
                    CategroyCode ="001",
                    Content="乡中心区"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "006",
                    CategroyCode ="001",
                    Content="村庄"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    ItemCode = "001",
                    CategroyCode ="002",
                    Content="省级行政区"
                },
                new DataItem
                {
                    Id = Guid.NewGuid(),
                    CategroyCode = "002",
                    ItemCode = "001",
                    Content = "地级行政区"
                },
                new DataItem
                {
                    ItemCode = "003",
                    Id = Guid.NewGuid(),
                    CategroyCode = "002",
                    Content = "县级行政区"
                },
                new DataItem
                {
                    ItemCode = "004",
                    Id = Guid.NewGuid(),
                    CategroyCode = "002",
                    Content = "乡级行政区"
                },
                new DataItem
                {
                    ItemCode = "005",
                    Id = Guid.NewGuid(),
                    CategroyCode = "002",
                    Content = "村级行政区"
                },
                 new DataItem
                 {
                     ItemCode = "001",
                     Id = Guid.NewGuid(),
                     CategroyCode = "003",
                     Content = "中共党员"
                 },
                  new DataItem
                  {
                      ItemCode = "002",
                      Id = Guid.NewGuid(),
                      CategroyCode = "003",
                      Content = "中共预备党员"
                  },
                   new DataItem
                   {
                       ItemCode = "003",
                       Id = Guid.NewGuid(),
                       CategroyCode = "003",
                       Content = "共青团员"
                   },
                    new DataItem
                    {
                        ItemCode = "004",
                        Id = Guid.NewGuid(),
                        CategroyCode = "003",
                        Content = "民革党员"
                    },
                     new DataItem
                     {
                         ItemCode = "005",
                         Id = Guid.NewGuid(),
                         CategroyCode = "003",
                         Content = "民盟盟员"
                     },
                      new DataItem
                      {
                          ItemCode = "006",
                          Id = Guid.NewGuid(),
                          CategroyCode = "003",
                          Content = "民建会员"
                      },
                        new DataItem
                        {
                            ItemCode = "007",
                            Id = Guid.NewGuid(),
                            CategroyCode = "003",
                            Content = "民进会员"
                        },
                          new DataItem
                          {
                              ItemCode = "008",
                              Id = Guid.NewGuid(),
                              CategroyCode = "003",
                              Content = "农工党党员"
                          },
                            new DataItem
                            {
                                ItemCode = "009",
                                Id = Guid.NewGuid(),
                                CategroyCode = "003",
                                Content = "致公党党员"
                            },

                            new DataItem
                            {
                                ItemCode = "010",
                                Id = Guid.NewGuid(),
                                CategroyCode = "003",
                                Content = "九三学社社员"
                            },
                            new DataItem
                            {
                                ItemCode = "011",
                                Id = Guid.NewGuid(),
                                CategroyCode = "003",
                                Content = "台盟盟员"
                            },
                            new DataItem
                            {
                                ItemCode = "012",
                                Id = Guid.NewGuid(),
                                CategroyCode = "003",
                                Content = "无党派人士"
                            },
                            new DataItem
                            {
                                ItemCode = "013",
                                Id = Guid.NewGuid(),
                                CategroyCode = "003",
                                Content = "群众"
                            }



                );
            #endregion
        }
    }
}
