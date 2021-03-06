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
    [Migration("20190404025205_Migration01")]
    partial class Migration01
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
                            Id = new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"),
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"),
                            RoleName = "Client"
                        },
                        new
                        {
                            Id = new Guid("82ba2bf6-f771-4494-8d09-83cf83c14223"),
                            RoleName = "System"
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
                            Id = new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba"),
                            Password = "admin",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = new Guid("3547564c-205f-4c21-a14d-5560c11f86c2"),
                            Password = "user1",
                            UserName = "user1"
                        },
                        new
                        {
                            Id = new Guid("b7f8222a-06bc-494b-bac4-d33dc11069fc"),
                            Password = "user2",
                            UserName = "user2"
                        },
                        new
                        {
                            Id = new Guid("f1f2b5e6-0e58-425e-9451-1051ba7a2a85"),
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
                            Id = new Guid("7fd94daf-5649-408a-8fde-16ff1cd058c0"),
                            RoleId = new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"),
                            UserId = new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba")
                        },
                        new
                        {
                            Id = new Guid("0e0453cd-142b-4061-83fe-4e44711904ae"),
                            RoleId = new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"),
                            UserId = new Guid("3547564c-205f-4c21-a14d-5560c11f86c2")
                        },
                        new
                        {
                            Id = new Guid("6d10f657-a1d9-4f4f-a1ed-5c01599061ba"),
                            RoleId = new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"),
                            UserId = new Guid("b7f8222a-06bc-494b-bac4-d33dc11069fc")
                        },
                        new
                        {
                            Id = new Guid("5d33e211-98e7-4b12-8a51-0c0bc6615c15"),
                            RoleId = new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"),
                            UserId = new Guid("f1f2b5e6-0e58-425e-9451-1051ba7a2a85")
                        },
                        new
                        {
                            Id = new Guid("2ddaea40-37dc-4359-8a88-6c44c4cd015b"),
                            RoleId = new Guid("82ba2bf6-f771-4494-8d09-83cf83c14223"),
                            UserId = new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba")
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
