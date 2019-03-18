using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villagers",
                columns: table => new
                {
                    VillagerID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    HomeAddress = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    AnnualIncome = table.Column<int>(nullable: false),
                    MaritalStatus = table.Column<string>(nullable: true),
                    HavingIllegalRecord = table.Column<bool>(nullable: false),
                    HavingCriminalRecord = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villagers", x => x.VillagerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villagers");
        }
    }
}
