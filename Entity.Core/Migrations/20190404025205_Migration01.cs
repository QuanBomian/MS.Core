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
                keyColumn: "Id",
                keyValue: new Guid("e6d92a3e-16bb-4bc1-8eeb-c388d1bb76d2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("310839b4-84f8-4cfd-b2d0-15f954ddfa96"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("3d185dab-6510-4eb8-ad6a-069aba82bbe9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("48903c94-34b0-491e-92d2-28cd70f20664"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("8809f73f-0b90-4851-bcbb-bb9cca4a148d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09fab3a8-3052-4ae6-9911-425a354732fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e51bb74d-4dad-4485-ac77-fb96e050ae81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("29055a06-9009-472f-8dfa-bcd27ea5b08a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fbf8d8e-0698-4fb5-9fb2-01146fdc53bf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f4f0a9a3-fab6-4061-9ed2-d05a07209754"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fe7ad19b-c203-4215-9f79-c830bae1f120"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
