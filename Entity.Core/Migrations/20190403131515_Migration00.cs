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
                    Id = table.Column<Guid>(nullable: false),
                    RoleName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Villagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Villagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("e51bb74d-4dad-4485-ac77-fb96e050ae81"), "Admin" },
                    { new Guid("09fab3a8-3052-4ae6-9911-425a354732fc"), "Client" },
                    { new Guid("e6d92a3e-16bb-4bc1-8eeb-c388d1bb76d2"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("29055a06-9009-472f-8dfa-bcd27ea5b08a"), "admin", "admin" },
                    { new Guid("7fbf8d8e-0698-4fb5-9fb2-01146fdc53bf"), "user1", "user1" },
                    { new Guid("f4f0a9a3-fab6-4061-9ed2-d05a07209754"), "user2", "user2" },
                    { new Guid("fe7ad19b-c203-4215-9f79-c830bae1f120"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3d185dab-6510-4eb8-ad6a-069aba82bbe9"), new Guid("e51bb74d-4dad-4485-ac77-fb96e050ae81"), new Guid("29055a06-9009-472f-8dfa-bcd27ea5b08a") },
                    { new Guid("8809f73f-0b90-4851-bcbb-bb9cca4a148d"), new Guid("09fab3a8-3052-4ae6-9911-425a354732fc"), new Guid("7fbf8d8e-0698-4fb5-9fb2-01146fdc53bf") },
                    { new Guid("310839b4-84f8-4cfd-b2d0-15f954ddfa96"), new Guid("09fab3a8-3052-4ae6-9911-425a354732fc"), new Guid("f4f0a9a3-fab6-4061-9ed2-d05a07209754") },
                    { new Guid("48903c94-34b0-491e-92d2-28cd70f20664"), new Guid("e51bb74d-4dad-4485-ac77-fb96e050ae81"), new Guid("fe7ad19b-c203-4215-9f79-c830bae1f120") }
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
