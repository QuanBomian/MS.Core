using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TownName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    MayorName = table.Column<string>(nullable: true),
                    SecretaryName = table.Column<string>(nullable: true),
                    ChairmanName = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("b850526d-c1ce-477c-a215-a2214e526efa"), "Admin" },
                    { new Guid("c431d8cb-a486-44cd-b7d5-17c98a978ec7"), "Client" },
                    { new Guid("607d8c28-7d29-44f3-88fa-edca11c34363"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "ChairmanName", "ContactPhone", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("95c88f48-bf82-48bb-879a-43271ed5fbd9"), "华杨路188号", "成梦昆", "0512-34813245", "刘赫伯", "蒋信迟", "周市镇" },
                    { new Guid("3d5e9b74-7ebb-4dbf-89ab-87ab7d4d0766"), "前进西路168号", "祖冲之", "0512-53387154", "陆机", "陆云", "昆山市高新区" },
                    { new Guid("0574ba7b-c37d-4b7e-973f-7622061159f8"), "前进东路", "邢栋祥", "0512-32416432", "逢建德", "匡俊智", "昆山开发区" },
                    { new Guid("276021b4-c8ed-46a5-86fb-42562ebcd7bc"), "花溪社区花溪路358号", "武财章", "0512-34872987", "王班", "吴启河", "昆山花桥经济开发区" },
                    { new Guid("1de0dcd1-703d-4275-9923-7e80e7fce148"), "宝觉街与茶风街交叉口北50米", "冯崇霆", "0521-84729179", "武财章", "李泰桓", "张浦镇" },
                    { new Guid("d7313ca3-a80e-4be6-b8bc-280b006f1324"), "普庆路1号", "邹鉴夕", "0521-32188912", "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("42187c82-cd0a-42e6-90f6-defa3e6580c7"), "菉溪路22号", "李迪尉", "0512-382748123", "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("4f9a949f-31fc-473f-8e58-32060bab74b5"), "新澄路918号", "周伟", "0521-76421843", "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("6e71cec2-dadf-46c3-9878-b7e6fe24888b"), "炎东路", "林修胜", "0512-28413451", "张弥成", "时可北", "千灯镇" },
                    { new Guid("3e8d0729-130d-420c-b81a-9bbbb77afa35"), "府前路78号", "常般业", "0512-83497432", "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("79b6f65b-022b-47a2-8870-842c5ca675ed"), "淀南路100号", "陆先", "0521-42124521", "王翱桦", "江衷力", "周庄镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("1087d97f-f744-4918-8337-6eb62c68e6b9"), "user1", "user1" },
                    { new Guid("c8de4b26-7e62-4721-a2e6-dc259cc829e0"), "admin", "admin" },
                    { new Guid("0673c88f-08e5-4c05-8efc-ebc0d053488b"), "user3", "user3" },
                    { new Guid("c1020c93-4907-4723-ad8f-52ca9d9a7a40"), "user2", "user2" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("d2ef9963-b3c6-44ec-a04a-b90233956cc6"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" },
                    { new Guid("162d1421-f193-422e-9f1b-370ca104bcf8"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("54ebc1f0-72fc-4a0f-abb4-1eaa7aeb4cc8"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cca9f0cd-fb5f-4c05-b7e4-cfd3529456c6"), new Guid("b850526d-c1ce-477c-a215-a2214e526efa"), new Guid("c8de4b26-7e62-4721-a2e6-dc259cc829e0") },
                    { new Guid("c3ecf70b-0ac9-4e43-93cf-9123338f77fb"), new Guid("607d8c28-7d29-44f3-88fa-edca11c34363"), new Guid("c8de4b26-7e62-4721-a2e6-dc259cc829e0") },
                    { new Guid("90587b8c-2a4c-4ad1-8c74-038219961dd9"), new Guid("c431d8cb-a486-44cd-b7d5-17c98a978ec7"), new Guid("1087d97f-f744-4918-8337-6eb62c68e6b9") },
                    { new Guid("751b1d07-f1dc-456c-a26a-4e0ad3e8e4d9"), new Guid("c431d8cb-a486-44cd-b7d5-17c98a978ec7"), new Guid("c1020c93-4907-4723-ad8f-52ca9d9a7a40") },
                    { new Guid("921120e7-a0ba-43e7-89ed-1b86891a5e5f"), new Guid("b850526d-c1ce-477c-a215-a2214e526efa"), new Guid("0673c88f-08e5-4c05-8efc-ebc0d053488b") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Towns");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("751b1d07-f1dc-456c-a26a-4e0ad3e8e4d9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("90587b8c-2a4c-4ad1-8c74-038219961dd9"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("921120e7-a0ba-43e7-89ed-1b86891a5e5f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c3ecf70b-0ac9-4e43-93cf-9123338f77fb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("cca9f0cd-fb5f-4c05-b7e4-cfd3529456c6"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("162d1421-f193-422e-9f1b-370ca104bcf8"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("54ebc1f0-72fc-4a0f-abb4-1eaa7aeb4cc8"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("d2ef9963-b3c6-44ec-a04a-b90233956cc6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("607d8c28-7d29-44f3-88fa-edca11c34363"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b850526d-c1ce-477c-a215-a2214e526efa"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c431d8cb-a486-44cd-b7d5-17c98a978ec7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0673c88f-08e5-4c05-8efc-ebc0d053488b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1087d97f-f744-4918-8337-6eb62c68e6b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1020c93-4907-4723-ad8f-52ca9d9a7a40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c8de4b26-7e62-4721-a2e6-dc259cc829e0"));

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
    }
}
