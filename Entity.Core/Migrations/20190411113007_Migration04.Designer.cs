﻿// <auto-generated />
using System;
using AspNetCore.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetCore.Entity.Migrations
{
    [DbContext(typeof(MsContext))]
    [Migration("20190411113007_Migration04")]
    partial class Migration04
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:PostgresExtension:uuid-ossp", ",,")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("AspNetCore.Entity.Core.Villager", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnnualIncome");

                    b.Property<DateTime>("Birthday");

                    b.Property<string>("Education");

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<bool>("HavingCriminalRecord");

                    b.Property<bool>("HavingIllegalRecord");

                    b.Property<string>("HomeAddress")
                        .IsRequired();

                    b.Property<string>("MaritalStatus");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Villagers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("77711553-3a33-466f-916c-0f45fb3995a0"),
                            AnnualIncome = 20000,
                            Birthday = new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Education = "高中",
                            Gender = "男",
                            HavingCriminalRecord = false,
                            HavingIllegalRecord = false,
                            HomeAddress = "向阳村3组14号",
                            MaritalStatus = "已婚",
                            Name = "张东"
                        },
                        new
                        {
                            Id = new Guid("dee89a1c-53a4-425c-b0c7-cfe309c66838"),
                            AnnualIncome = 17000,
                            Birthday = new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Education = "初中",
                            Gender = "男",
                            HavingCriminalRecord = false,
                            HavingIllegalRecord = false,
                            HomeAddress = "向阳村5组17号",
                            MaritalStatus = "已婚",
                            Name = "刘项"
                        },
                        new
                        {
                            Id = new Guid("fc514fd4-eca3-4d36-b97b-e790387e52a9"),
                            AnnualIncome = 50000,
                            Birthday = new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Education = "本科",
                            Gender = "男",
                            HavingCriminalRecord = false,
                            HavingIllegalRecord = false,
                            HomeAddress = "向阳村1组2号",
                            MaritalStatus = "未婚",
                            Name = "马伦"
                        });
                });

            modelBuilder.Entity("AspNetCore.Entity.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"),
                            RoleName = "Client"
                        },
                        new
                        {
                            Id = new Guid("fc12f373-d6bc-4bf3-8755-9d20ea51ba2f"),
                            RoleName = "System"
                        });
                });

            modelBuilder.Entity("AspNetCore.Entity.Town", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ChairmanName");

                    b.Property<string>("ContactPhone");

                    b.Property<string>("MayorName");

                    b.Property<string>("SecretaryName");

                    b.Property<string>("TownName");

                    b.HasKey("Id");

                    b.ToTable("Towns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea602d6e-c89f-4b39-ae6a-c01943664261"),
                            Address = "前进西路168号",
                            ChairmanName = "祖冲之",
                            ContactPhone = "0512-53387154",
                            MayorName = "陆机",
                            SecretaryName = "陆云",
                            TownName = "昆山市高新区"
                        },
                        new
                        {
                            Id = new Guid("65664686-89c6-40f5-9e36-ea0dd7caab55"),
                            Address = "前进东路",
                            ChairmanName = "邢栋祥",
                            ContactPhone = "0512-32416432",
                            MayorName = "逢建德",
                            SecretaryName = "匡俊智",
                            TownName = "昆山开发区"
                        },
                        new
                        {
                            Id = new Guid("14883e40-8340-4b2f-b374-745c311d7350"),
                            Address = "花溪路358号",
                            ChairmanName = "武财章",
                            ContactPhone = "0512-34872987",
                            MayorName = "王班",
                            SecretaryName = "吴启河",
                            TownName = "昆山花桥经济开发区"
                        },
                        new
                        {
                            Id = new Guid("31eddee4-39e7-4c56-86f4-649cb3294fbf"),
                            Address = "宝觉街与茶风街交叉口北50米",
                            ChairmanName = "冯崇霆",
                            ContactPhone = "0521-84729179",
                            MayorName = "武财章",
                            SecretaryName = "李泰桓",
                            TownName = "张浦镇"
                        },
                        new
                        {
                            Id = new Guid("d64853a5-7feb-43e0-99a1-2f83ccf2c369"),
                            Address = "华杨路188号",
                            ChairmanName = "成梦昆",
                            ContactPhone = "0512-34813245",
                            MayorName = "刘赫伯",
                            SecretaryName = "蒋信迟",
                            TownName = "周市镇"
                        },
                        new
                        {
                            Id = new Guid("65b6c3fb-ef80-45f7-bdbe-aa356bbb3caa"),
                            Address = "菉溪路22号",
                            ChairmanName = "李迪尉",
                            ContactPhone = "0512-38274812",
                            MayorName = "梁灶慈",
                            SecretaryName = "刘群胜",
                            TownName = "陆家镇"
                        },
                        new
                        {
                            Id = new Guid("8414bcfc-169c-46a5-9035-57614c813845"),
                            Address = "新澄路918号",
                            ChairmanName = "周伟",
                            ContactPhone = "0521-76421843",
                            MayorName = "李迪尉",
                            SecretaryName = "钟开桦",
                            TownName = "巴城镇"
                        },
                        new
                        {
                            Id = new Guid("d5389ccb-4bb5-458d-9672-a0b59e5fcb8f"),
                            Address = "炎东路",
                            ChairmanName = "林修胜",
                            ContactPhone = "0512-28413451",
                            MayorName = "张弥成",
                            SecretaryName = "时可北",
                            TownName = "千灯镇"
                        },
                        new
                        {
                            Id = new Guid("49e6ac7b-f26b-491f-bdbe-8f0a9292739e"),
                            Address = "府前路78号",
                            ChairmanName = "常般业",
                            ContactPhone = "0512-83497432",
                            MayorName = "冯便磊",
                            SecretaryName = "颜尚冲",
                            TownName = "淀山湖镇"
                        },
                        new
                        {
                            Id = new Guid("7514439e-6e6c-441f-b17d-ec86254ace19"),
                            Address = "淀南路100号",
                            ChairmanName = "陆先",
                            ContactPhone = "0521-42124521",
                            MayorName = "王翱桦",
                            SecretaryName = "江衷力",
                            TownName = "周庄镇"
                        },
                        new
                        {
                            Id = new Guid("4a46b593-8206-4c1c-a8ed-b4b103da1fc0"),
                            Address = "普庆路1号",
                            ChairmanName = "邹鉴夕",
                            ContactPhone = "0521-32188912",
                            MayorName = "倪御奋",
                            SecretaryName = "姬道生",
                            TownName = "锦溪镇"
                        });
                });

            modelBuilder.Entity("AspNetCore.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503"),
                            Password = "admin",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("f177ccf3-d80a-4652-9e15-9f50e2e0edb8"),
                            Password = "user1",
                            UserName = "user1"
                        },
                        new
                        {
                            Id = new Guid("2bc08067-9b7d-44b0-8449-7da2bdb4239c"),
                            Password = "user2",
                            UserName = "user2"
                        },
                        new
                        {
                            Id = new Guid("01f6375b-d229-466f-b9eb-4a472d52e425"),
                            Password = "user3",
                            UserName = "user3"
                        });
                });

            modelBuilder.Entity("AspNetCore.Entity.UserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bce71577-ef53-4687-a258-c253f2e2d3f2"),
                            RoleId = new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"),
                            UserId = new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503")
                        },
                        new
                        {
                            Id = new Guid("3eec8571-5991-4361-85ca-7a9b584d02d4"),
                            RoleId = new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"),
                            UserId = new Guid("f177ccf3-d80a-4652-9e15-9f50e2e0edb8")
                        },
                        new
                        {
                            Id = new Guid("7d909ad8-a5fb-4a72-a5e4-f4872322487d"),
                            RoleId = new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"),
                            UserId = new Guid("2bc08067-9b7d-44b0-8449-7da2bdb4239c")
                        },
                        new
                        {
                            Id = new Guid("2d7fecee-364e-4a64-b942-5b67d6f8cebb"),
                            RoleId = new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"),
                            UserId = new Guid("01f6375b-d229-466f-b9eb-4a472d52e425")
                        },
                        new
                        {
                            Id = new Guid("961c4cb3-50cf-4398-bc5c-89faaed9a966"),
                            RoleId = new Guid("fc12f373-d6bc-4bf3-8755-9d20ea51ba2f"),
                            UserId = new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503")
                        });
                });

            modelBuilder.Entity("AspNetCore.Entity.UserRole", b =>
                {
                    b.HasOne("AspNetCore.Entity.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspNetCore.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
