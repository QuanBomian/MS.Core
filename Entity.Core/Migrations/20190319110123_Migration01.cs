using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("382417ca-b56d-47bc-8db2-e9c1930592c3"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("2251f609-dbbd-4055-841d-a2a89e934529"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("530a4517-764d-437f-9144-3bf9163bcf3a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("82f2fdb8-4f10-41f7-abb1-c06f88cae53e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: new Guid("b59896fc-c433-4267-8a13-edacfa4233a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("36f4a336-5239-4519-8f53-0783d5fa7f27"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("aed0a076-7111-4a5e-bfff-6055850a11cd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4ba9e9b7-36ef-40da-8e3c-849c2673cf0f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("78e16794-f853-445c-9879-f150f8f817be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("859c27dd-48b3-4512-80ad-c3c7a46118e4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8e423e51-56e6-4ef5-85fa-6373c96269c5"));

            migrationBuilder.RenameColumn(
                name: "VillagerId",
                table: "Villagers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserRoleId",
                table: "UserRoles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Roles",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("68337de8-4e74-46e4-8106-cbba7c5f1dd2"), "Admin" },
                    { new Guid("55e03c6e-1a5c-4400-bc93-89a335d65f36"), "Client" },
                    { new Guid("83dfab26-61d6-4217-961e-d851d4a84be9"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("94af1519-77b0-4c2c-bf5b-e89ddcd156f8"), "admin", "admin" },
                    { new Guid("b1678831-72e3-44e0-9756-de794763b95e"), "user1", "user1" },
                    { new Guid("88370eb7-923e-4f27-8f28-3362851aae85"), "user2", "user2" },
                    { new Guid("5cc65f3d-05be-45d2-9321-e126de4fb503"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("182abc09-ec5b-4f42-98d0-3043fa0b8b7c"), new Guid("68337de8-4e74-46e4-8106-cbba7c5f1dd2"), new Guid("94af1519-77b0-4c2c-bf5b-e89ddcd156f8") },
                    { new Guid("c67bb54c-9b63-44d1-9d58-deed372902e7"), new Guid("55e03c6e-1a5c-4400-bc93-89a335d65f36"), new Guid("b1678831-72e3-44e0-9756-de794763b95e") },
                    { new Guid("98c0c635-66fe-4881-8d1d-24861cdb1d28"), new Guid("55e03c6e-1a5c-4400-bc93-89a335d65f36"), new Guid("88370eb7-923e-4f27-8f28-3362851aae85") },
                    { new Guid("110ef886-c129-41d9-9943-b14aa2be5cc1"), new Guid("68337de8-4e74-46e4-8106-cbba7c5f1dd2"), new Guid("5cc65f3d-05be-45d2-9321-e126de4fb503") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("83dfab26-61d6-4217-961e-d851d4a84be9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("110ef886-c129-41d9-9943-b14aa2be5cc1"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("182abc09-ec5b-4f42-98d0-3043fa0b8b7c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("98c0c635-66fe-4881-8d1d-24861cdb1d28"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c67bb54c-9b63-44d1-9d58-deed372902e7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("55e03c6e-1a5c-4400-bc93-89a335d65f36"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68337de8-4e74-46e4-8106-cbba7c5f1dd2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cc65f3d-05be-45d2-9321-e126de4fb503"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("88370eb7-923e-4f27-8f28-3362851aae85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("94af1519-77b0-4c2c-bf5b-e89ddcd156f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1678831-72e3-44e0-9756-de794763b95e"));

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Villagers",
                newName: "VillagerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserRoles",
                newName: "UserRoleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { new Guid("36f4a336-5239-4519-8f53-0783d5fa7f27"), "Admin" },
                    { new Guid("aed0a076-7111-4a5e-bfff-6055850a11cd"), "Client" },
                    { new Guid("382417ca-b56d-47bc-8db2-e9c1930592c3"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("4ba9e9b7-36ef-40da-8e3c-849c2673cf0f"), "admin", "admin" },
                    { new Guid("8e423e51-56e6-4ef5-85fa-6373c96269c5"), "user1", "user1" },
                    { new Guid("859c27dd-48b3-4512-80ad-c3c7a46118e4"), "user2", "user2" },
                    { new Guid("78e16794-f853-445c-9879-f150f8f817be"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("82f2fdb8-4f10-41f7-abb1-c06f88cae53e"), new Guid("36f4a336-5239-4519-8f53-0783d5fa7f27"), new Guid("4ba9e9b7-36ef-40da-8e3c-849c2673cf0f") },
                    { new Guid("530a4517-764d-437f-9144-3bf9163bcf3a"), new Guid("aed0a076-7111-4a5e-bfff-6055850a11cd"), new Guid("8e423e51-56e6-4ef5-85fa-6373c96269c5") },
                    { new Guid("b59896fc-c433-4267-8a13-edacfa4233a4"), new Guid("aed0a076-7111-4a5e-bfff-6055850a11cd"), new Guid("859c27dd-48b3-4512-80ad-c3c7a46118e4") },
                    { new Guid("2251f609-dbbd-4055-841d-a2a89e934529"), new Guid("36f4a336-5239-4519-8f53-0783d5fa7f27"), new Guid("78e16794-f853-445c-9879-f150f8f817be") }
                });
        }
    }
}
