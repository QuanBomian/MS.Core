using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("0e0453cd-142b-4061-83fe-4e44711904ae"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("2ddaea40-37dc-4359-8a88-6c44c4cd015b"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5d33e211-98e7-4b12-8a51-0c0bc6615c15"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6d10f657-a1d9-4f4f-a1ed-5c01599061ba"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7fd94daf-5649-408a-8fde-16ff1cd058c0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("82ba2bf6-f771-4494-8d09-83cf83c14223"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3547564c-205f-4c21-a14d-5560c11f86c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7f8222a-06bc-494b-bac4-d33dc11069fc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f1f2b5e6-0e58-425e-9451-1051ba7a2a85"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("67542bef-54c4-4089-a26d-659ff8632366"), "Admin" },
                    { new Guid("a3436326-d071-47d5-b7a0-50a7a2c5f1d4"), "Client" },
                    { new Guid("ce90150e-74dd-4f85-859d-510010f82e0e"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("ccaf6a0a-2425-4cbd-9101-78e223e9a1e3"), "admin", "admin" },
                    { new Guid("79b50bdb-0bf8-4bfc-867c-5c338695c797"), "user1", "user1" },
                    { new Guid("71744faf-3abc-44bc-bc85-050a0f5b1d08"), "user2", "user2" },
                    { new Guid("6a8e3022-c8f2-4e12-990b-724008c20434"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("58c605a9-307d-4c57-96f0-705585548863"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" },
                    { new Guid("ae9b3600-a38f-4f84-8d25-87d414e0d5e6"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("feea26af-6ed7-48e2-9011-a7f2a4f788e4"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("81aedbbc-028a-4db1-97ff-8f9142edf53f"), new Guid("67542bef-54c4-4089-a26d-659ff8632366"), new Guid("ccaf6a0a-2425-4cbd-9101-78e223e9a1e3") },
                    { new Guid("00aa7a43-acd2-4725-90bd-9358679c67a3"), new Guid("ce90150e-74dd-4f85-859d-510010f82e0e"), new Guid("ccaf6a0a-2425-4cbd-9101-78e223e9a1e3") },
                    { new Guid("280d2b4f-0a04-48d1-8faa-5f3e76370668"), new Guid("a3436326-d071-47d5-b7a0-50a7a2c5f1d4"), new Guid("79b50bdb-0bf8-4bfc-867c-5c338695c797") },
                    { new Guid("269d36fd-cca9-43ff-92c5-f5f3698e3ed6"), new Guid("a3436326-d071-47d5-b7a0-50a7a2c5f1d4"), new Guid("71744faf-3abc-44bc-bc85-050a0f5b1d08") },
                    { new Guid("155881d0-53c5-4bf8-bbc4-0e20f4a0cedc"), new Guid("67542bef-54c4-4089-a26d-659ff8632366"), new Guid("6a8e3022-c8f2-4e12-990b-724008c20434") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("00aa7a43-acd2-4725-90bd-9358679c67a3"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("155881d0-53c5-4bf8-bbc4-0e20f4a0cedc"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("269d36fd-cca9-43ff-92c5-f5f3698e3ed6"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("280d2b4f-0a04-48d1-8faa-5f3e76370668"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("81aedbbc-028a-4db1-97ff-8f9142edf53f"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("58c605a9-307d-4c57-96f0-705585548863"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("ae9b3600-a38f-4f84-8d25-87d414e0d5e6"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("feea26af-6ed7-48e2-9011-a7f2a4f788e4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("67542bef-54c4-4089-a26d-659ff8632366"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a3436326-d071-47d5-b7a0-50a7a2c5f1d4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ce90150e-74dd-4f85-859d-510010f82e0e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a8e3022-c8f2-4e12-990b-724008c20434"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("71744faf-3abc-44bc-bc85-050a0f5b1d08"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("79b50bdb-0bf8-4bfc-867c-5c338695c797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ccaf6a0a-2425-4cbd-9101-78e223e9a1e3"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"), "Admin" },
                    { new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"), "Client" },
                    { new Guid("82ba2bf6-f771-4494-8d09-83cf83c14223"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba"), "admin", "admin" },
                    { new Guid("3547564c-205f-4c21-a14d-5560c11f86c2"), "user1", "user1" },
                    { new Guid("b7f8222a-06bc-494b-bac4-d33dc11069fc"), "user2", "user2" },
                    { new Guid("f1f2b5e6-0e58-425e-9451-1051ba7a2a85"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7fd94daf-5649-408a-8fde-16ff1cd058c0"), new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"), new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba") },
                    { new Guid("2ddaea40-37dc-4359-8a88-6c44c4cd015b"), new Guid("82ba2bf6-f771-4494-8d09-83cf83c14223"), new Guid("d6ce9598-c482-482f-947c-ad000c71f2ba") },
                    { new Guid("0e0453cd-142b-4061-83fe-4e44711904ae"), new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"), new Guid("3547564c-205f-4c21-a14d-5560c11f86c2") },
                    { new Guid("6d10f657-a1d9-4f4f-a1ed-5c01599061ba"), new Guid("95ce9501-abb6-4371-9b4a-2331fa01caf3"), new Guid("b7f8222a-06bc-494b-bac4-d33dc11069fc") },
                    { new Guid("5d33e211-98e7-4b12-8a51-0c0bc6615c15"), new Guid("8dd7b971-ff4d-4e16-9f9c-f8c2178dedaa"), new Guid("f1f2b5e6-0e58-425e-9451-1051ba7a2a85") }
                });
        }
    }
}
