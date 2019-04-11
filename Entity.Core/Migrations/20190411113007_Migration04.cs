using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0574ba7b-c37d-4b7e-973f-7622061159f8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1de0dcd1-703d-4275-9923-7e80e7fce148"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("276021b4-c8ed-46a5-86fb-42562ebcd7bc"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3d5e9b74-7ebb-4dbf-89ab-87ab7d4d0766"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3e8d0729-130d-420c-b81a-9bbbb77afa35"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("42187c82-cd0a-42e6-90f6-defa3e6580c7"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4f9a949f-31fc-473f-8e58-32060bab74b5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6e71cec2-dadf-46c3-9878-b7e6fe24888b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("79b6f65b-022b-47a2-8870-842c5ca675ed"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("95c88f48-bf82-48bb-879a-43271ed5fbd9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d7313ca3-a80e-4be6-b8bc-280b006f1324"));

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
                    { new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"), "Admin" },
                    { new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"), "Client" },
                    { new Guid("fc12f373-d6bc-4bf3-8755-9d20ea51ba2f"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "ChairmanName", "ContactPhone", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("d64853a5-7feb-43e0-99a1-2f83ccf2c369"), "华杨路188号", "成梦昆", "0512-34813245", "刘赫伯", "蒋信迟", "周市镇" },
                    { new Guid("ea602d6e-c89f-4b39-ae6a-c01943664261"), "前进西路168号", "祖冲之", "0512-53387154", "陆机", "陆云", "昆山市高新区" },
                    { new Guid("65664686-89c6-40f5-9e36-ea0dd7caab55"), "前进东路", "邢栋祥", "0512-32416432", "逢建德", "匡俊智", "昆山开发区" },
                    { new Guid("14883e40-8340-4b2f-b374-745c311d7350"), "花溪路358号", "武财章", "0512-34872987", "王班", "吴启河", "昆山花桥经济开发区" },
                    { new Guid("31eddee4-39e7-4c56-86f4-649cb3294fbf"), "宝觉街与茶风街交叉口北50米", "冯崇霆", "0521-84729179", "武财章", "李泰桓", "张浦镇" },
                    { new Guid("4a46b593-8206-4c1c-a8ed-b4b103da1fc0"), "普庆路1号", "邹鉴夕", "0521-32188912", "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("65b6c3fb-ef80-45f7-bdbe-aa356bbb3caa"), "菉溪路22号", "李迪尉", "0512-38274812", "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("8414bcfc-169c-46a5-9035-57614c813845"), "新澄路918号", "周伟", "0521-76421843", "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("d5389ccb-4bb5-458d-9672-a0b59e5fcb8f"), "炎东路", "林修胜", "0512-28413451", "张弥成", "时可北", "千灯镇" },
                    { new Guid("49e6ac7b-f26b-491f-bdbe-8f0a9292739e"), "府前路78号", "常般业", "0512-83497432", "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("7514439e-6e6c-441f-b17d-ec86254ace19"), "淀南路100号", "陆先", "0521-42124521", "王翱桦", "江衷力", "周庄镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("f177ccf3-d80a-4652-9e15-9f50e2e0edb8"), "user1", "user1" },
                    { new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503"), "admin", "admin" },
                    { new Guid("01f6375b-d229-466f-b9eb-4a472d52e425"), "user3", "user3" },
                    { new Guid("2bc08067-9b7d-44b0-8449-7da2bdb4239c"), "user2", "user2" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("fc514fd4-eca3-4d36-b97b-e790387e52a9"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" },
                    { new Guid("dee89a1c-53a4-425c-b0c7-cfe309c66838"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("77711553-3a33-466f-916c-0f45fb3995a0"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("bce71577-ef53-4687-a258-c253f2e2d3f2"), new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"), new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503") },
                    { new Guid("961c4cb3-50cf-4398-bc5c-89faaed9a966"), new Guid("fc12f373-d6bc-4bf3-8755-9d20ea51ba2f"), new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503") },
                    { new Guid("3eec8571-5991-4361-85ca-7a9b584d02d4"), new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"), new Guid("f177ccf3-d80a-4652-9e15-9f50e2e0edb8") },
                    { new Guid("7d909ad8-a5fb-4a72-a5e4-f4872322487d"), new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"), new Guid("2bc08067-9b7d-44b0-8449-7da2bdb4239c") },
                    { new Guid("2d7fecee-364e-4a64-b942-5b67d6f8cebb"), new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"), new Guid("01f6375b-d229-466f-b9eb-4a472d52e425") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("14883e40-8340-4b2f-b374-745c311d7350"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("31eddee4-39e7-4c56-86f4-649cb3294fbf"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("49e6ac7b-f26b-491f-bdbe-8f0a9292739e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4a46b593-8206-4c1c-a8ed-b4b103da1fc0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("65664686-89c6-40f5-9e36-ea0dd7caab55"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("65b6c3fb-ef80-45f7-bdbe-aa356bbb3caa"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7514439e-6e6c-441f-b17d-ec86254ace19"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("8414bcfc-169c-46a5-9035-57614c813845"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d5389ccb-4bb5-458d-9672-a0b59e5fcb8f"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d64853a5-7feb-43e0-99a1-2f83ccf2c369"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ea602d6e-c89f-4b39-ae6a-c01943664261"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("2d7fecee-364e-4a64-b942-5b67d6f8cebb"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("3eec8571-5991-4361-85ca-7a9b584d02d4"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("7d909ad8-a5fb-4a72-a5e4-f4872322487d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("961c4cb3-50cf-4398-bc5c-89faaed9a966"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("bce71577-ef53-4687-a258-c253f2e2d3f2"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("77711553-3a33-466f-916c-0f45fb3995a0"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("dee89a1c-53a4-425c-b0c7-cfe309c66838"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("fc514fd4-eca3-4d36-b97b-e790387e52a9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("13c4d819-125d-4eb0-b8f8-11729aeb0e86"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("99240aa0-cab9-4f1c-b8bb-425ad3ae14ed"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc12f373-d6bc-4bf3-8755-9d20ea51ba2f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("01f6375b-d229-466f-b9eb-4a472d52e425"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2bc08067-9b7d-44b0-8449-7da2bdb4239c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("da0e7338-d7b3-4a57-abf6-44d67a3c4503"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f177ccf3-d80a-4652-9e15-9f50e2e0edb8"));

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
    }
}
