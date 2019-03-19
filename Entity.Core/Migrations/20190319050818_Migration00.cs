using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", ",,");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Villagers",
                columns: table => new
                {
                    VillagerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: false),
                    HomeAddress = table.Column<string>(nullable: false),
                    Education = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: true),
                    HavingIllegalRecord = table.Column<bool>(nullable: false),
                    HavingCriminalRecord = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villagers", x => x.VillagerId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Villagers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
