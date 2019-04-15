using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7162f5ad-36dd-4af1-bf92-9a21b0e0db0c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("912beb45-42a2-4716-9ddc-4b37ca553ed0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("c7108c8b-adfc-4fb2-b33c-bde4e6315830"));

            migrationBuilder.DeleteData(
                table: "Families",
                keyColumn: "Id",
                keyValue: new Guid("ba450f6b-8658-4a36-8f18-84da7419849d"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("23fba69e-7db1-4cd2-a710-5174761fb01a"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("4748fd35-799c-4a0f-a307-c0931db5c1bb"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("a54ff9c8-a586-43c2-80eb-f5fcf2d158f1"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("daae710c-aaff-4848-8a8f-96e44fa23f0a"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("ddf3ebce-2871-4276-aa6c-9a045d248436"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("5efff05c-36dd-43c4-8643-6ce33b681b7b"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("8392697f-5868-4ef2-8859-2f896625e25e"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("98d891c9-cb69-4d31-824a-15c72b549b0d"));

            migrationBuilder.DeleteData(
                table: "PartyMembers",
                keyColumn: "Id",
                keyValue: new Guid("53ee6f71-6778-4e7e-8989-2487d142f327"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("08453ee9-bec1-4e2a-887d-562d6ee776e0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0faa3a66-04f6-4e86-ba9d-8dd15b92b5f2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("293d9015-608b-4ae8-b2fd-db30b18d8b66"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3a0a86c8-2c44-4955-9c3b-5656ae859a21"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7221bd56-c75d-482d-a365-9137a7927d02"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("7b231c5b-e1e6-41d4-9846-4b2c4a53bfb5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b49dfcc1-d532-442b-a61b-95b02073b0a0"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("cbdbba4a-76ed-4702-a299-7cf6c23db178"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e317961a-1f40-4e02-8bf9-85c9103f543b"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f93b99df-ddc3-4f7d-8c4a-cce3671d894e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("33feb476-b3c3-41e7-9370-ef89fd7395d0"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6b476148-2a7f-4fbc-9f54-e07b4172f237"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("8832bbc3-c00a-4a18-ad03-846a868c63ba"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("99e5aade-d140-47e7-9415-cb232cb5f018"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("f4dd464c-23f5-4a12-9cd2-2c9655cca32b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("15dd7b33-2ed1-4be6-b033-cea3d84b3c01"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("196a1297-171d-41a6-849c-33a58866cf5d"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("1cd5267a-f80a-43c5-b1c1-6857e9a2e33b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("51d7ddc9-5937-43b3-8cd5-73cebead2ef4"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("a6cfbe82-a2c0-49be-a891-faa4a9cdc5e7"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("aae32069-85a9-49db-9903-6b73211b178c"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("be591c76-d3ac-44f0-9af6-1e201652bf26"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("ce9ebb65-d590-4998-99c8-8c9c19a5e21b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("e1ecd62a-ca51-45fc-8913-fe9a495f34b2"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("f85088a8-13c6-46e6-9b23-5f88ea930e87"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("fbe9893e-0df3-4215-8eaf-9498b28e8891"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("fcc54963-7b46-459a-aee1-bceb8081f0d3"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("77912e9e-25cf-4378-b592-59f9a1280c15"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("7951e894-3fb6-46d0-8043-265bdf601987"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("ec98a2e9-ce01-49ba-969b-32ae19072ed8"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("01eca90f-61a7-4e41-b616-385406f0970c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("042c3b4f-4cbf-4918-b591-da3eb452821e"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("09c775d0-22c5-4dce-89a8-4b7439c91001"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("269dd6f5-ec4b-4ee0-8105-009ad243f769"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("2a896bdc-dce7-4bb0-8482-bf6d4d6a9e5a"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("399d103c-47e9-4b76-872b-f5bd1750df09"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("43801da0-5b91-4299-ab7b-369bcade7db7"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("45cc78be-cfe1-4582-9ed9-0a0663b90d8e"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("490aa6dc-f98b-4a95-86e2-cf861633df74"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("4bae5d35-8a55-444c-ab99-b6fffdd610ef"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("4ee2c305-eadf-450e-ab03-237f7fae968c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("54355e56-dffb-405a-a47b-fa80aee411d9"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("5f7ad0c4-85d1-4b54-8fe9-3b2f6a468361"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("6127e717-2d92-494b-a5ae-1b945c1e797c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("69d1acf8-7b52-4e9a-ba55-23823fa59f5c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("6cdcbbe6-110c-439b-bc6d-df66574da26c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("7c855afb-67a5-4a5f-84ce-7a255aae271e"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("87655703-592a-46b6-b419-cddff8c945d6"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("9058555b-1f9a-45bf-a3f7-d4f65f9c99d3"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("a5d44dae-19cf-432e-8947-5352c554e10d"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("a886ed0c-e4e4-43f6-968d-3e8337c1c93a"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("ada54008-c294-43df-81d9-bcb9a6f3e4d0"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("b259705b-2642-4abc-91cd-5b2c2f12c847"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("bece5423-64a4-456e-8f32-5f03ea06d95e"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("ce3303ef-e496-4d92-9078-c2ee0fb9f24a"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("d7ddcb53-821d-44d6-9511-7b9e090ec763"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("e6b69ccb-6b1b-4343-a96b-4f647ed02299"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("667e1876-c225-4beb-b060-3391708a9398"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f7ebaae8-37cc-4eff-ab86-92ca58a9a597"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa956970-367a-4d4d-ab84-78873ba1fbb1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("303e6c31-59f2-421b-8470-6d51cf0ca30f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4bcf8798-dd21-4bcd-b169-dbd01efa6c8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("97b485b3-819b-4128-95fe-35a8074fa282"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("af3677a1-fc12-401b-bbbe-e1eee13ac5cc"));

            migrationBuilder.CreateTable(
                name: "AdminDivisions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HighLevelAreaNumber = table.Column<string>(nullable: true),
                    AreaNumber = table.Column<string>(nullable: true),
                    GovernmentLevel = table.Column<int>(nullable: false),
                    GovernmentName = table.Column<string>(nullable: true),
                    CountyNumber = table.Column<int>(nullable: false),
                    VillageNumber = table.Column<int>(nullable: false),
                    VillageGroupNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminDivisions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AdminDivisions",
                columns: new[] { "Id", "AreaNumber", "CountyNumber", "GovernmentLevel", "GovernmentName", "HighLevelAreaNumber", "VillageGroupNumber", "VillageNumber" },
                values: new object[,]
                {
                    { new Guid("0387baed-836d-49bc-be1a-d1691f59fddb"), "320583000000", 0, 3, "昆山市", "", 2205, 10 },
                    { new Guid("e4716e3c-4f19-464a-905c-0d37de504548"), "320583106003", 0, 5, "振苏社区", "320583106000", 12, 0 },
                    { new Guid("07e38f1f-2577-49da-822d-ae75649ca594"), "320583106002", 0, 5, "花园社区", "320583106000", 12, 0 },
                    { new Guid("ae267179-9a10-4c80-8268-853786f5e966"), "320583106001", 0, 5, "张浦社区", "320583106000", 12, 0 },
                    { new Guid("bbc700a6-03e4-4a64-8d36-b380a97dbe03"), "320583109000", 0, 4, "锦溪镇", "320583000000", 256, 22 },
                    { new Guid("db93b46d-6195-49f4-8191-ef4036110b82"), "320583107000", 0, 4, "周庄镇", "320583000000", 123, 31 },
                    { new Guid("e3794a01-748a-4cde-82c7-c21cffb25e21"), "320583105000", 0, 4, "淀山湖镇", "320583000000", 173, 11 },
                    { new Guid("3775994b-0556-4883-b9d4-e42e4bf07615"), "320583108000", 0, 4, "千灯镇", "320583000000", 213, 41 },
                    { new Guid("8dea4e0c-98f8-4caa-89c6-c15d5dde07d4"), "320583106004", 0, 5, "南港社区", "320583106000", 12, 0 },
                    { new Guid("b2bcb90b-003d-45f6-86d9-a999280b5523"), "320583101000", 0, 4, "巴城镇", "320583000000", 216, 13 },
                    { new Guid("1b549175-d02e-487c-ade5-4ab8dd8eab7c"), "320583101000", 0, 4, "巴城镇", "320583000000", 216, 13 },
                    { new Guid("5c175f0a-cede-48a5-aebf-cd88f0f9c708"), "320583103000", 0, 4, "陆家镇", "320583000000", 231, 13 },
                    { new Guid("0458c3ce-e80d-42d1-9d98-d2ff6c413b59"), "320583106000", 0, 4, "张浦镇", "320583000000", 221, 12 },
                    { new Guid("464e2a0c-de9a-4a29-9ae2-bdcf2ec4be63"), "320583104000", 0, 4, "花桥镇", "320583000000", 123, 13 },
                    { new Guid("4d399b64-e030-4762-a459-719a3a278e52"), "320583400000", 0, 4, "开发区", "320583000000", 312, 7 },
                    { new Guid("93d9ba17-d321-4f6a-bbe6-e65e8285115b"), "320583102000", 0, 4, "周市镇", "320583000000", 240, 29 },
                    { new Guid("c6e3105b-6883-4c00-82ac-d92a9f7295a6"), "320583101000", 0, 4, "巴城镇", "320583000000", 216, 13 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "ContactPhone", "DepartmentCode", "DepartmentName", "Email", "Fax", "Notes", "PrincipalName" },
                values: new object[,]
                {
                    { new Guid("2ccd9cfa-74c0-4e6e-91ad-f5ffea51e2d5"), "花苑路与京东路交叉口西侧", "0512-54128123", "003", "花园社区党支部委员会", "xugaoyi@kszpzp.gov.cn", "0512-564178314", null, "许高义" },
                    { new Guid("f164074a-c46d-4e67-89bb-64933e305c87"), "京东路469号", "0512-57623451", "001", "张浦社区党支部委员会", "zhenxinguo@kszpzp.gov.cn", "0512-54123412", "", "郑兴国" },
                    { new Guid("356a0885-12d3-4baa-8488-8230a1913741"), "京东路469号", "0512-58289432", "002", "张浦社区居民委员会", "chenlecheng@kszpzp.gov.cn", "0512-59283414", "临时兼任", "陈乐成" }
                });

            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "AccountCharacter", "AverageAnnualIncome", "AverageHousingArea", "FamilyCode", "Householder", "HousingArea", "IsLowIncome", "IsPoor", "PeopleNumber", "VillageGroupCode", "VillageName" },
                values: new object[] { new Guid("f86d2484-6714-443d-8c8e-8a2d31e60bc4"), "非农业", 5000, 20.84f, "001000", "秦博厚", 104.2f, false, false, 5, "001", null });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthday", "DepartmentCode", "Education", "EntryTime", "Gender", "HomeAddress", "IdCardNumber", "LeaveTime", "LengthOfService", "MaritalStatus", "MemberCode", "MemberName", "Nationality", "PersonnelNature", "PoliticalStatus", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("407c17ce-597f-4663-bfbe-5ffc7f5ca8fa"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村14号", "320583197407056857", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002000", "陈乐成", "汉族", null, "中共党员", "主任", "在职" },
                    { new Guid("2af3af03-02df-4c95-b8a9-6bef9d1868c3"), new DateTime(1977, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2002, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇浦江北新村112号", "320583197707087692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17年", "已婚", "002001", "姜兴安", "汉族", null, "中共党员", "副主任", "在职" },
                    { new Guid("38591f2f-ad4a-4131-8003-fe76e041edfc"), new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "高中", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村56号", "320583198504178937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9年", "丧偶", "002002", "于君昊", "汉族", null, "中共党员", "治调委员", "在职" },
                    { new Guid("536f3911-1b81-434d-9ce0-b6befe473a6d"), new DateTime(1979, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "硕士研究生", new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村12号", "320583197910154878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14年", "离异", "002003", "康志国", "汉族", null, "群众", "财经委员", "在职" },
                    { new Guid("b13781d2-3fd4-46e4-acb9-79ce8a194ec6"), new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "女", "张浦镇江北新村17号", "320583198704187965", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002004", "赵陈红", "汉族", null, "群众", "妇女计生委员", "在职" }
                });

            migrationBuilder.InsertData(
                table: "NonOperatingAssets",
                columns: new[] { "Id", "LibaryCollectionsNumber", "LibraryNumber", "OfficeBuildingArea", "OfficeBuildingNumber", "SeniorCitizenCenterArea", "SeniorCitizenCenterNumber", "ServiceStationNumber", "SportActivityRoomArea", "SportsActivityRoomNumber", "StaffQuarterArea", "StaffQuartersNumber", "VillageName" },
                values: new object[,]
                {
                    { new Guid("88ca0853-912a-4df6-9c8f-0f416d1e0a35"), 3000, 1, 105f, 1, 450f, 1, 4, 1000f, 2, 1000f, 1, "张浦社区" },
                    { new Guid("28314b8a-fd71-4c97-8a33-cc148bbede7b"), 2500, 1, 172f, 1, 380f, 1, 2, 800f, 1, 1200f, 1, "花园社区" },
                    { new Guid("3f1b9bc1-1e14-4807-b057-35daddbfd921"), 5000, 1, 250f, 2, 700f, 2, 1, 1500f, 3, 2000f, 2, "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "PartyMembers",
                columns: new[] { "Id", "Birthday", "ContactPhone", "DepartmentCode", "Education", "Gender", "IsFullMember", "MemberCode", "Nationality", "PartyMemberName", "PartyOrganizationName", "PartyPosition", "VillageName" },
                values: new object[] { new Guid("0055c71d-19ae-4653-a9be-c69a1f5d6a67"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "13057134712", "001", "本科", "男", true, "001000", "汉族", "陈乐成", "张浦社区党支部委员会", "无", "张浦社区" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("3cddd6dd-3d43-4c23-8f67-ba17916b4b1f"), "System" },
                    { new Guid("6819af08-0b4b-4537-9ad0-2ab11ba1340e"), "Client" },
                    { new Guid("bc9077b4-c5a8-46a8-8e77-f934e5d17d6a"), "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "AreaNumber", "ChairmanName", "ContactPhone", "GovernmentLevel", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("c5893c85-3470-4679-8272-96387d306a5d"), "新澄路918号", "320583101000", "周伟", "0521-57656330", 4, "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("af2f0ed8-ac87-4101-97b8-c0608782006e"), "炎东路", "320583108000", "林修胜", "0512-36620396", 4, "张弥成", "时可北", "千灯镇" },
                    { new Guid("5d863c7e-8200-40e6-94c4-768ae1e6c9a9"), "府前路78号", "320583105000", "常般业", "0512-57488358", 4, "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("437313c6-e49e-4d67-810d-762536dd6c1d"), "普庆路1号", "320583109000", "邹鉴夕", "0521-57231290", 4, "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("5732ec3f-4213-4d4b-956f-7bba2d1b4a84"), "菉溪路22号", "	320583103000", "李迪尉", "0512-57671003", 4, "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("eda79180-1263-4d10-ba3c-3d39a136f67d"), "华杨路188号", "320583106000", "成梦昆", "0512-57452503", 4, "刘赫伯", "蒋信迟", "张浦镇" },
                    { new Guid("435299e4-c9c5-4ebb-ae96-d293545549a2"), "淀南路100号", "320583107000", "陆先", "0521-57211236", 4, "王翱桦", "江衷力", "周庄镇" },
                    { new Guid("429c5703-5333-4cd8-9604-7829927ddc86"), "前进东路", "320583400000", "邢栋祥", "0512-57329416", 4, "逢建德", "匡俊智", "开发区" },
                    { new Guid("ac1ec2aa-df9b-4105-babe-915a33db964d"), "花溪路358号", "320583104000", "武财章", "0512-57698733", 4, "王班", "吴启河", "花桥镇" },
                    { new Guid("71bffd6d-957b-4fad-b82c-194bb49cd331"), "前进西路168号", "320583102000", "祖冲之", "0512-57621053", 4, "陆机", "陆云", "周市镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("b1584dcd-c492-4e92-a128-40357c36596e"), "admin", "admin" },
                    { new Guid("2b1aaa70-00a4-4e64-9ee6-43cf22156b14"), "user1", "user1" },
                    { new Guid("539cbbf2-2bec-498a-9a8a-f64c8f848a1d"), "user3", "user3" },
                    { new Guid("d7f45dcb-74e6-4c58-bd9b-cd9fa4066920"), "user2", "user2" }
                });

            migrationBuilder.InsertData(
                table: "VillagerGroups",
                columns: new[] { "Id", "MemberNumber", "PrincipalAddress", "PrincipalEmail", "PrincipalName", "PrincipalPhone", "VillageGroupCode", "VillageName" },
                values: new object[,]
                {
                    { new Guid("d2c95fe0-4169-4913-a795-32db94f4e5b8"), 662, "张浦镇牡丹苑7幢502", "zhongjunde@kszpmdy.gov.cn", "钟俊德", null, "010", "周巷社区" },
                    { new Guid("855c3a7f-c1af-4db2-aa9b-8462c37100a3"), 452, "张浦镇银鹿新城3幢802室", "heliren@kszpylxc.gov.cn", "何立人", null, "009", "张浦社区" },
                    { new Guid("5debdc32-2676-4f30-bf5f-5f9b87363321"), 345, "张浦镇张浦村142号", "xuexiuxian@kszpzp.gov.cn", "薛修贤", null, "008", "张浦社区" },
                    { new Guid("943e9a97-9fc1-4456-b40a-cf213d49854a"), 476, "张浦镇张浦村14号", "huhaorang@kszpzp.gov.cn", "胡浩壤", null, "007", "张浦社区" },
                    { new Guid("f33c45d4-481b-4136-a126-1ed4b9415528"), 356, "张浦镇望江新村6幢206室", "wuxuefei@kszpwz.gov.cn", "吴雪峰", "0512-57841234", "001", "南港社区" },
                    { new Guid("d35cee6b-c614-4126-9d72-6df55d2cc86f"), 567, "张浦镇枫情佳苑3幢306室", "kongzhiwen@kszpfqjy.gov.cn", "孔志文", null, "006", "新吴社区" },
                    { new Guid("fdeefc62-b9ab-43ee-8b76-4f64a5bd5271"), 512, "张浦镇风和日丽5幢1102室", "qianyancheng@kszpfhrl.gov.cn", "钱阳成", null, "005", "南港社区" },
                    { new Guid("cf810ea4-85e7-47e3-a2dc-b9449becf860"), 253, "张浦镇富仁小区5幢102室", "changgaohan@kszpfr.gov.cn", "常高翰", null, "004", "大市社区" },
                    { new Guid("c4c8e94c-51f2-4add-b586-d2fde3fd8015"), 532, "张浦镇茶风新村1幢206室", "caogao@kszpcf.gov.cn", "蔡高", null, "003", "花园社区" },
                    { new Guid("36b30ad7-2996-4f99-9f09-95c9dfad6d99"), 412, "张浦镇富都新村3幢204室", "fangjitong@kszpfd.gov.cn", "方季同", null, "002", "南港社区" },
                    { new Guid("fedfe912-c4ae-4f9d-9eb4-68f206579afd"), 543, "张浦镇安居小区24号", "duanxuehai@kszpanxq.gov.cn", "段学海", null, "012", "大市社区" },
                    { new Guid("4e67a4aa-b94f-4766-bcd8-307c4a9326a0"), 341, "张浦镇江南春堤14号", "jiatianzong@kszpjnkd.gov.cn", "贾天纵", null, "011", "新巷社区" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("f8650d08-8232-4e7b-91ca-edeaa50eaa78"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" },
                    { new Guid("d6a55bef-ec66-4561-82dc-b51ed0eaf84a"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("270d3953-7b76-4e8c-97b7-67ba4a44065e"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Address", "AreaNumber", "ContactPhone", "GovernmentLevel", "GroupCount", "HighLevelAreaNumber", "SecretaryName", "UrbanRuralClassification", "VillageHeadName", "VillageName" },
                values: new object[,]
                {
                    { new Guid("e1411b5a-aeaf-489a-aa4f-0eb8ec467816"), "周巷路", "320583106009", "0512-57294577", 5, 40, "320583106000", "姜永昌", 111, "吴凯凯", "周巷社区" },
                    { new Guid("f7610492-ea41-4a5d-a304-fe088a503455"), "京东路469号", "320583106001", "0512-57441175", 5, 12, "320583106000", "尹乐和", 111, "赵乐欣", "张浦社区" },
                    { new Guid("7bc02a90-9c0a-45d2-b291-39e8acbeb6c7"), "花苑路与京东路交叉口西侧", "320583106002", "0512-36863123", 5, 26, "320583106000", "汤振海", 111, "杜向阳", "花园社区" },
                    { new Guid("202a0240-1e8e-4ccc-8377-01faf79d2bfa"), "振苏六村", "320583106003", "0512-55270465", 5, null, "320583106000", "廖景天", 111, "崔泰宁", "振苏社区" },
                    { new Guid("242c5877-2ebf-4354-a107-529ef69df130"), "震阳路126号", "320583106004", "0512-57428835", 5, null, "320583106000", "阎乐池", 121, "尹和蔼", "南港社区" },
                    { new Guid("efba154a-a716-43c1-b268-56665854fade"), "淞沪西路36号", "320583106005", "0512-57256550", 5, null, "320583106000", "许宏畅", 220, "薛兴为", "大市社区" },
                    { new Guid("eea279da-5e02-4364-8b6d-882629a90e86"), "俱巷路894号", "320583106006", "0512-36691258", 5, null, "320583106000", "孔浩思", 111, "王康胜", "新巷社区" },
                    { new Guid("8a23f0d1-b823-407b-922c-c6591f0821af"), "淞沪东路12号", "320583106227", "0512-57251131", 5, null, "320583106000", "朱嘉石", 220, "顾飞羽", "南吉山村" },
                    { new Guid("00670456-6c33-4659-a096-ffbd932e3e0f"), "淞沪西路与江浦南路交叉口", "320583106226", "0512-57255236", 5, 49, "320583106000", "顾绍祺", 220, "金和怡", "大市村" },
                    { new Guid("36f1a282-ff79-462f-abf2-16f8c47afeaa"), "姚家港北首", "320583106221", "0512-57117756", 5, 22, "320583106000", "杨成仁", 220, "谢高义", "南姚村" },
                    { new Guid("550683b9-4f4d-45d7-bf7e-7e33d768643b"), "大直路504号", "320583106008", "0512-55272500", 5, 23, "320583106000", "梁奇希", 112, "吕勇男", "大直社区" },
                    { new Guid("75a74032-c72d-4c22-b24c-25cb645479fe"), "长江南路东侧与锦溪北交界", "320583106220", "0512-57256590", 5, 21, "320583106000", "汤英耀", 220, "蒋嘉许", "尚明甸村" },
                    { new Guid("8e62970e-5d09-44ac-b270-ac770515bed1"), "安头村公交站台往南60米处", "320583106215", "0512-57428927", 5, 25, "320583106000", "郝嘉慕", 220, "史意蕴", "安头村" },
                    { new Guid("814e62da-e80c-4bf6-a6d5-da8aceff66d7"), "南港文体站", "320583106214", "0512-57428327", 5, 28, "320583106000", "蒋英卓", 220, "冯兴庆", "林庄村" },
                    { new Guid("1f988319-1dd4-4ada-a3c2-a12baacd4ef3"), "建林路往北到底向西100米", "320583106212", "0512-57120550", 5, null, "320583106000", "万安怡", 220, "萧波峻", "白米村" },
                    { new Guid("f3e864e1-491f-4943-b5a4-4753ea64d276"), "陈邱家浜58号", "320583106211", "0512-50331469", 5, 44, "320583106000", "孙明杰", 220, "谭睿诚", "新龙村" },
                    { new Guid("7afbc522-b769-4144-b64d-23ce7f99d1ff"), "震阳路与双娄路交叉口", "320583106210", "0512-57421150", 5, 35, "320583106000", "贺博艺", 122, "冯鹏赋", "星金村" },
                    { new Guid("1f3fe98d-49b0-4cb7-8060-0b34c6a52d3f"), "盛巷花园门卫北侧", "320583106209", "0512-57441616", 5, 20, "320583106000", "韩华藏", 111, "萧泰河", "新塘村" },
                    { new Guid("c2e674ac-68c2-446a-bae8-e5aa0985287f"), "港浦东路8号", "320583106207", "0512-5736863220", 5, 33, "320583106000", "史光临", 111, "陈浦和", "三家村" },
                    { new Guid("8d77535b-c012-419f-a7d8-9c366f82e947"), "商秧路178号", "320583106007", "0512-55272500", 5, 26, "320583106000", "吴俊晤", 111, "石欣德", "新吴社区" },
                    { new Guid("97bf19d7-0a84-40b3-b539-85f7e81a1355"), "机场路与兴陵路交叉口往南200米", "320583106205", "0512-57441476", 5, 27, "320583106000", "邹俊雄", 220, "程飞虎", "赵陵村" },
                    { new Guid("1f52a3f3-18e4-42c0-bc5c-f3c800cca76a"), "商鞅路1号", "320583106204", "0512-50310612", 5, 20, "320583106000", "汤明亮", 112, "吴咏德", "七桥村" },
                    { new Guid("d11315b0-b1b7-4154-91fc-6cdac48870ce"), "金华路1号", "320583106200", "0512-57293702", 5, 26, "320583106000", "宋翰学", 112, "龙昊焱", "金华村" },
                    { new Guid("d20ba91f-3553-4f8e-a814-6f7e0b160a83"), "京东路731号", "320583106013", "0512-57278938", 5, null, "320583106000", "李段", 111, "吕尊", "锦和社区" },
                    { new Guid("41e0337e-09a5-4992-92e3-12e145983bdb"), "京东路588号", "320583106012", "0512-57883298", 5, null, "320583106000", "龙澔", 111, "汤烨磊", "亲和社区" },
                    { new Guid("62be4d5b-a548-4d04-a91e-2e295c0a7502"), "江浦南路与C325交叉处", "320583106219", "0512-57272133", 5, 23, "320583106000", "漕文彦", 220, "许高岑", "姜杭村" },
                    { new Guid("cbd439b0-6bd3-4d4e-a630-aa65d9bd4bf0"), "川浩路22号", "320583106206", "0512-57441101", 5, null, "320583106000", "丁弘亮", 220, "龚炎彬", "吴加村" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("572b55c0-da7f-4070-8cfc-23ec80a7e773"), new Guid("bc9077b4-c5a8-46a8-8e77-f934e5d17d6a"), new Guid("b1584dcd-c492-4e92-a128-40357c36596e") },
                    { new Guid("72d95943-19d2-4e16-ad69-cf6cdca32f89"), new Guid("3cddd6dd-3d43-4c23-8f67-ba17916b4b1f"), new Guid("b1584dcd-c492-4e92-a128-40357c36596e") },
                    { new Guid("6eee6d65-b4fe-4d42-9b21-0a09cf8e0491"), new Guid("6819af08-0b4b-4537-9ad0-2ab11ba1340e"), new Guid("2b1aaa70-00a4-4e64-9ee6-43cf22156b14") },
                    { new Guid("1a511339-8501-4a11-85b7-a3915c4118db"), new Guid("6819af08-0b4b-4537-9ad0-2ab11ba1340e"), new Guid("d7f45dcb-74e6-4c58-bd9b-cd9fa4066920") },
                    { new Guid("2b842230-a9a1-45bf-ab32-2f6e0bb2a1f2"), new Guid("bc9077b4-c5a8-46a8-8e77-f934e5d17d6a"), new Guid("539cbbf2-2bec-498a-9a8a-f64c8f848a1d") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminDivisions");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2ccd9cfa-74c0-4e6e-91ad-f5ffea51e2d5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("356a0885-12d3-4baa-8488-8230a1913741"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("f164074a-c46d-4e67-89bb-64933e305c87"));

            migrationBuilder.DeleteData(
                table: "Families",
                keyColumn: "Id",
                keyValue: new Guid("f86d2484-6714-443d-8c8e-8a2d31e60bc4"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("2af3af03-02df-4c95-b8a9-6bef9d1868c3"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("38591f2f-ad4a-4131-8003-fe76e041edfc"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("407c17ce-597f-4663-bfbe-5ffc7f5ca8fa"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("536f3911-1b81-434d-9ce0-b6befe473a6d"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("b13781d2-3fd4-46e4-acb9-79ce8a194ec6"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("28314b8a-fd71-4c97-8a33-cc148bbede7b"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("3f1b9bc1-1e14-4807-b057-35daddbfd921"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("88ca0853-912a-4df6-9c8f-0f416d1e0a35"));

            migrationBuilder.DeleteData(
                table: "PartyMembers",
                keyColumn: "Id",
                keyValue: new Guid("0055c71d-19ae-4653-a9be-c69a1f5d6a67"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("429c5703-5333-4cd8-9604-7829927ddc86"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("435299e4-c9c5-4ebb-ae96-d293545549a2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("437313c6-e49e-4d67-810d-762536dd6c1d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5732ec3f-4213-4d4b-956f-7bba2d1b4a84"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("5d863c7e-8200-40e6-94c4-768ae1e6c9a9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("71bffd6d-957b-4fad-b82c-194bb49cd331"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ac1ec2aa-df9b-4105-babe-915a33db964d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("af2f0ed8-ac87-4101-97b8-c0608782006e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c5893c85-3470-4679-8272-96387d306a5d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("eda79180-1263-4d10-ba3c-3d39a136f67d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("1a511339-8501-4a11-85b7-a3915c4118db"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("2b842230-a9a1-45bf-ab32-2f6e0bb2a1f2"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("572b55c0-da7f-4070-8cfc-23ec80a7e773"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6eee6d65-b4fe-4d42-9b21-0a09cf8e0491"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("72d95943-19d2-4e16-ad69-cf6cdca32f89"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("36b30ad7-2996-4f99-9f09-95c9dfad6d99"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("4e67a4aa-b94f-4766-bcd8-307c4a9326a0"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("5debdc32-2676-4f30-bf5f-5f9b87363321"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("855c3a7f-c1af-4db2-aa9b-8462c37100a3"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("943e9a97-9fc1-4456-b40a-cf213d49854a"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("c4c8e94c-51f2-4add-b586-d2fde3fd8015"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("cf810ea4-85e7-47e3-a2dc-b9449becf860"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("d2c95fe0-4169-4913-a795-32db94f4e5b8"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("d35cee6b-c614-4126-9d72-6df55d2cc86f"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("f33c45d4-481b-4136-a126-1ed4b9415528"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("fdeefc62-b9ab-43ee-8b76-4f64a5bd5271"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("fedfe912-c4ae-4f9d-9eb4-68f206579afd"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("270d3953-7b76-4e8c-97b7-67ba4a44065e"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("d6a55bef-ec66-4561-82dc-b51ed0eaf84a"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("f8650d08-8232-4e7b-91ca-edeaa50eaa78"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("00670456-6c33-4659-a096-ffbd932e3e0f"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1f3fe98d-49b0-4cb7-8060-0b34c6a52d3f"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1f52a3f3-18e4-42c0-bc5c-f3c800cca76a"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1f988319-1dd4-4ada-a3c2-a12baacd4ef3"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("202a0240-1e8e-4ccc-8377-01faf79d2bfa"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("242c5877-2ebf-4354-a107-529ef69df130"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("36f1a282-ff79-462f-abf2-16f8c47afeaa"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("41e0337e-09a5-4992-92e3-12e145983bdb"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("550683b9-4f4d-45d7-bf7e-7e33d768643b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("62be4d5b-a548-4d04-a91e-2e295c0a7502"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("75a74032-c72d-4c22-b24c-25cb645479fe"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("7afbc522-b769-4144-b64d-23ce7f99d1ff"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("7bc02a90-9c0a-45d2-b291-39e8acbeb6c7"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("814e62da-e80c-4bf6-a6d5-da8aceff66d7"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("8a23f0d1-b823-407b-922c-c6591f0821af"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("8d77535b-c012-419f-a7d8-9c366f82e947"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("8e62970e-5d09-44ac-b270-ac770515bed1"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("97bf19d7-0a84-40b3-b539-85f7e81a1355"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("c2e674ac-68c2-446a-bae8-e5aa0985287f"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("cbd439b0-6bd3-4d4e-a630-aa65d9bd4bf0"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("d11315b0-b1b7-4154-91fc-6cdac48870ce"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("d20ba91f-3553-4f8e-a814-6f7e0b160a83"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("e1411b5a-aeaf-489a-aa4f-0eb8ec467816"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("eea279da-5e02-4364-8b6d-882629a90e86"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("efba154a-a716-43c1-b268-56665854fade"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("f3e864e1-491f-4943-b5a4-4753ea64d276"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("f7610492-ea41-4a5d-a304-fe088a503455"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3cddd6dd-3d43-4c23-8f67-ba17916b4b1f"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6819af08-0b4b-4537-9ad0-2ab11ba1340e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bc9077b4-c5a8-46a8-8e77-f934e5d17d6a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b1aaa70-00a4-4e64-9ee6-43cf22156b14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("539cbbf2-2bec-498a-9a8a-f64c8f848a1d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b1584dcd-c492-4e92-a128-40357c36596e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d7f45dcb-74e6-4c58-bd9b-cd9fa4066920"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "ContactPhone", "DepartmentCode", "DepartmentName", "Email", "Fax", "Notes", "PrincipalName" },
                values: new object[,]
                {
                    { new Guid("c7108c8b-adfc-4fb2-b33c-bde4e6315830"), "京东路469号", "0512-57623451", "001", "张浦社区党支部委员会", "zhenxinguo@kszpzp.gov.cn", "0512-54123412", "", "郑兴国" },
                    { new Guid("7162f5ad-36dd-4af1-bf92-9a21b0e0db0c"), "京东路469号", "0512-58289432", "002", "张浦社区居民委员会", "chenlecheng@kszpzp.gov.cn", "0512-59283414", "临时兼任", "陈乐成" },
                    { new Guid("912beb45-42a2-4716-9ddc-4b37ca553ed0"), "花苑路与京东路交叉口西侧", "0512-54128123", "003", "花园社区党支部委员会", "xugaoyi@kszpzp.gov.cn", "0512-564178314", null, "许高义" }
                });

            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "AccountCharacter", "AverageAnnualIncome", "AverageHousingArea", "FamilyCode", "Householder", "HousingArea", "IsLowIncome", "IsPoor", "PeopleNumber", "VillageGroupCode", "VillageName" },
                values: new object[] { new Guid("ba450f6b-8658-4a36-8f18-84da7419849d"), "非农业", 5000, 20.84f, "001000", "秦博厚", 104.2f, false, false, 5, "001", null });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthday", "DepartmentCode", "Education", "EntryTime", "Gender", "HomeAddress", "IdCardNumber", "LeaveTime", "LengthOfService", "MaritalStatus", "MemberCode", "MemberName", "Nationality", "PersonnelNature", "PoliticalStatus", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("23fba69e-7db1-4cd2-a710-5174761fb01a"), new DateTime(1979, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "硕士研究生", new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村12号", "320583197910154878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14年", "离异", "002003", "康志国", "汉族", null, "群众", "财经委员", "在职" },
                    { new Guid("ddf3ebce-2871-4276-aa6c-9a045d248436"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村14号", "320583197407056857", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002000", "陈乐成", "汉族", null, "中共党员", "主任", "在职" },
                    { new Guid("4748fd35-799c-4a0f-a307-c0931db5c1bb"), new DateTime(1977, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2002, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇浦江北新村112号", "320583197707087692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17年", "已婚", "002001", "姜兴安", "汉族", null, "中共党员", "副主任", "在职" },
                    { new Guid("a54ff9c8-a586-43c2-80eb-f5fcf2d158f1"), new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "高中", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村56号", "320583198504178937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9年", "丧偶", "002002", "于君昊", "汉族", null, "中共党员", "治调委员", "在职" },
                    { new Guid("daae710c-aaff-4848-8a8f-96e44fa23f0a"), new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "女", "张浦镇江北新村17号", "320583198704187965", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002004", "赵陈红", "汉族", null, "群众", "妇女计生委员", "在职" }
                });

            migrationBuilder.InsertData(
                table: "NonOperatingAssets",
                columns: new[] { "Id", "LibaryCollectionsNumber", "LibraryNumber", "OfficeBuildingArea", "OfficeBuildingNumber", "SeniorCitizenCenterArea", "SeniorCitizenCenterNumber", "ServiceStationNumber", "SportActivityRoomArea", "SportsActivityRoomNumber", "StaffQuarterArea", "StaffQuartersNumber", "VillageName" },
                values: new object[,]
                {
                    { new Guid("98d891c9-cb69-4d31-824a-15c72b549b0d"), 3000, 1, 105f, 1, 450f, 1, 4, 1000f, 2, 1000f, 1, "张浦社区" },
                    { new Guid("5efff05c-36dd-43c4-8643-6ce33b681b7b"), 2500, 1, 172f, 1, 380f, 1, 2, 800f, 1, 1200f, 1, "花园社区" },
                    { new Guid("8392697f-5868-4ef2-8859-2f896625e25e"), 5000, 1, 250f, 2, 700f, 2, 1, 1500f, 3, 2000f, 2, "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "PartyMembers",
                columns: new[] { "Id", "Birthday", "ContactPhone", "DepartmentCode", "Education", "Gender", "IsFullMember", "MemberCode", "Nationality", "PartyMemberName", "PartyOrganizationName", "PartyPosition", "VillageName" },
                values: new object[] { new Guid("53ee6f71-6778-4e7e-8989-2487d142f327"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "13057134712", "001", "本科", "男", true, "001000", "汉族", "陈乐成", "张浦社区党支部委员会", "无", "张浦社区" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("f7ebaae8-37cc-4eff-ab86-92ca58a9a597"), "System" },
                    { new Guid("667e1876-c225-4beb-b060-3391708a9398"), "Admin" },
                    { new Guid("fa956970-367a-4d4d-ab84-78873ba1fbb1"), "Client" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "AreaNumber", "ChairmanName", "ContactPhone", "GovernmentLevel", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("08453ee9-bec1-4e2a-887d-562d6ee776e0"), "淀南路100号", "320583107000", "陆先", "0521-57211236", 4, "王翱桦", "江衷力", "周庄镇" },
                    { new Guid("7b231c5b-e1e6-41d4-9846-4b2c4a53bfb5"), "府前路78号", "320583105000", "常般业", "0512-57488358", 4, "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("293d9015-608b-4ae8-b2fd-db30b18d8b66"), "普庆路1号", "320583109000", "邹鉴夕", "0521-57231290", 4, "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("cbdbba4a-76ed-4702-a299-7cf6c23db178"), "炎东路", "320583108000", "林修胜", "0512-36620396", 4, "张弥成", "时可北", "千灯镇" },
                    { new Guid("e317961a-1f40-4e02-8bf9-85c9103f543b"), "新澄路918号", "320583101000", "周伟", "0521-57656330", 4, "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("7221bd56-c75d-482d-a365-9137a7927d02"), "菉溪路22号", "	320583103000", "李迪尉", "0512-57671003", 4, "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("0faa3a66-04f6-4e86-ba9d-8dd15b92b5f2"), "前进东路", "320583400000", "邢栋祥", "0512-57329416", 4, "逢建德", "匡俊智", "开发区" },
                    { new Guid("3a0a86c8-2c44-4955-9c3b-5656ae859a21"), "花溪路358号", "320583104000", "武财章", "0512-57698733", 4, "王班", "吴启河", "花桥镇" },
                    { new Guid("b49dfcc1-d532-442b-a61b-95b02073b0a0"), "前进西路168号", "320583102000", "祖冲之", "0512-57621053", 4, "陆机", "陆云", "周市镇" },
                    { new Guid("f93b99df-ddc3-4f7d-8c4a-cce3671d894e"), "华杨路188号", "320583106000", "成梦昆", "0512-57452503", 4, "刘赫伯", "蒋信迟", "张浦镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("4bcf8798-dd21-4bcd-b169-dbd01efa6c8a"), "admin", "admin" },
                    { new Guid("af3677a1-fc12-401b-bbbe-e1eee13ac5cc"), "user1", "user1" },
                    { new Guid("97b485b3-819b-4128-95fe-35a8074fa282"), "user2", "user2" },
                    { new Guid("303e6c31-59f2-421b-8470-6d51cf0ca30f"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "VillagerGroups",
                columns: new[] { "Id", "MemberNumber", "PrincipalAddress", "PrincipalEmail", "PrincipalName", "PrincipalPhone", "VillageGroupCode", "VillageName" },
                values: new object[,]
                {
                    { new Guid("a6cfbe82-a2c0-49be-a891-faa4a9cdc5e7"), 512, "张浦镇风和日丽5幢1102室", "qianyancheng@kszpfhrl.gov.cn", "钱阳成", null, "005", "南港社区" },
                    { new Guid("aae32069-85a9-49db-9903-6b73211b178c"), 567, "张浦镇枫情佳苑3幢306室", "kongzhiwen@kszpfqjy.gov.cn", "孔志文", null, "006", "新吴社区" },
                    { new Guid("e1ecd62a-ca51-45fc-8913-fe9a495f34b2"), 253, "张浦镇富仁小区5幢102室", "changgaohan@kszpfr.gov.cn", "常高翰", null, "004", "大市社区" },
                    { new Guid("be591c76-d3ac-44f0-9af6-1e201652bf26"), 532, "张浦镇茶风新村1幢206室", "caogao@kszpcf.gov.cn", "蔡高", null, "003", "花园社区" },
                    { new Guid("196a1297-171d-41a6-849c-33a58866cf5d"), 341, "张浦镇江南春堤14号", "jiatianzong@kszpjnkd.gov.cn", "贾天纵", null, "011", "新巷社区" },
                    { new Guid("15dd7b33-2ed1-4be6-b033-cea3d84b3c01"), 543, "张浦镇安居小区24号", "duanxuehai@kszpanxq.gov.cn", "段学海", null, "012", "大市社区" },
                    { new Guid("fbe9893e-0df3-4215-8eaf-9498b28e8891"), 345, "张浦镇张浦村142号", "xuexiuxian@kszpzp.gov.cn", "薛修贤", null, "008", "张浦社区" },
                    { new Guid("1cd5267a-f80a-43c5-b1c1-6857e9a2e33b"), 412, "张浦镇富都新村3幢204室", "fangjitong@kszpfd.gov.cn", "方季同", null, "002", "南港社区" },
                    { new Guid("fcc54963-7b46-459a-aee1-bceb8081f0d3"), 452, "张浦镇银鹿新城3幢802室", "heliren@kszpylxc.gov.cn", "何立人", null, "009", "张浦社区" },
                    { new Guid("ce9ebb65-d590-4998-99c8-8c9c19a5e21b"), 662, "张浦镇牡丹苑7幢502", "zhongjunde@kszpmdy.gov.cn", "钟俊德", null, "010", "周巷社区" },
                    { new Guid("f85088a8-13c6-46e6-9b23-5f88ea930e87"), 476, "张浦镇张浦村14号", "huhaorang@kszpzp.gov.cn", "胡浩壤", null, "007", "张浦社区" },
                    { new Guid("51d7ddc9-5937-43b3-8cd5-73cebead2ef4"), 356, "张浦镇望江新村6幢206室", "wuxuefei@kszpwz.gov.cn", "吴雪峰", "0512-57841234", "001", "南港社区" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("7951e894-3fb6-46d0-8043-265bdf601987"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" },
                    { new Guid("ec98a2e9-ce01-49ba-969b-32ae19072ed8"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("77912e9e-25cf-4378-b592-59f9a1280c15"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Address", "AreaNumber", "ContactPhone", "GovernmentLevel", "GroupCount", "HighLevelAreaNumber", "SecretaryName", "UrbanRuralClassification", "VillageHeadName", "VillageName" },
                values: new object[,]
                {
                    { new Guid("d7ddcb53-821d-44d6-9511-7b9e090ec763"), "京东路731号", "320583106013", "0512-57278938", 5, null, "320583106000", "李段", 111, "吕尊", "锦和社区" },
                    { new Guid("01eca90f-61a7-4e41-b616-385406f0970c"), "京东路469号", "320583106001", "0512-57441175", 5, 12, "320583106000", "尹乐和", 111, "赵乐欣", "张浦社区" },
                    { new Guid("490aa6dc-f98b-4a95-86e2-cf861633df74"), "花苑路与京东路交叉口西侧", "320583106002", "0512-36863123", 5, 26, "320583106000", "汤振海", 111, "杜向阳", "花园社区" },
                    { new Guid("ce3303ef-e496-4d92-9078-c2ee0fb9f24a"), "震阳路126号", "320583106004", "0512-57428835", 5, null, "320583106000", "阎乐池", 121, "尹和蔼", "南港社区" },
                    { new Guid("a886ed0c-e4e4-43f6-968d-3e8337c1c93a"), "淞沪西路36号", "320583106005", "0512-57256550", 5, null, "320583106000", "许宏畅", 220, "薛兴为", "大市社区" },
                    { new Guid("b259705b-2642-4abc-91cd-5b2c2f12c847"), "俱巷路894号", "320583106006", "0512-36691258", 5, null, "320583106000", "孔浩思", 111, "王康胜", "新巷社区" },
                    { new Guid("042c3b4f-4cbf-4918-b591-da3eb452821e"), "商秧路178号", "320583106007", "0512-55272500", 5, 26, "320583106000", "吴俊晤", 111, "石欣德", "新吴社区" },
                    { new Guid("e6b69ccb-6b1b-4343-a96b-4f647ed02299"), "大直路504号", "320583106008", "0512-55272500", 5, 23, "320583106000", "梁奇希", 112, "吕勇男", "大直社区" },
                    { new Guid("45cc78be-cfe1-4582-9ed9-0a0663b90d8e"), "周巷路", "320583106009", "0512-57294577", 5, 40, "320583106000", "姜永昌", 111, "吴凯凯", "周巷社区" },
                    { new Guid("6127e717-2d92-494b-a5ae-1b945c1e797c"), "淞沪东路12号", "320583106227", "0512-57251131", 5, null, "320583106000", "朱嘉石", 220, "顾飞羽", "南吉山村" },
                    { new Guid("9058555b-1f9a-45bf-a3f7-d4f65f9c99d3"), "淞沪西路与江浦南路交叉口", "320583106226", "0512-57255236", 5, 49, "320583106000", "顾绍祺", 220, "金和怡", "大市村" },
                    { new Guid("ada54008-c294-43df-81d9-bcb9a6f3e4d0"), "京东路588号", "320583106012", "0512-57883298", 5, null, "320583106000", "龙澔", 111, "汤烨磊", "亲和社区" },
                    { new Guid("a5d44dae-19cf-432e-8947-5352c554e10d"), "姚家港北首", "320583106221", "0512-57117756", 5, 22, "320583106000", "杨成仁", 220, "谢高义", "南姚村" },
                    { new Guid("7c855afb-67a5-4a5f-84ce-7a255aae271e"), "江浦南路与C325交叉处", "320583106219", "0512-57272133", 5, 23, "320583106000", "漕文彦", 220, "许高岑", "姜杭村" },
                    { new Guid("2a896bdc-dce7-4bb0-8482-bf6d4d6a9e5a"), "安头村公交站台往南60米处", "320583106215", "0512-57428927", 5, 25, "320583106000", "郝嘉慕", 220, "史意蕴", "安头村" },
                    { new Guid("43801da0-5b91-4299-ab7b-369bcade7db7"), "南港文体站", "320583106214", "0512-57428327", 5, 28, "320583106000", "蒋英卓", 220, "冯兴庆", "林庄村" },
                    { new Guid("69d1acf8-7b52-4e9a-ba55-23823fa59f5c"), "建林路往北到底向西100米", "320583106212", "0512-57120550", 5, null, "320583106000", "万安怡", 220, "萧波峻", "白米村" },
                    { new Guid("87655703-592a-46b6-b419-cddff8c945d6"), "陈邱家浜58号", "320583106211", "0512-50331469", 5, 44, "320583106000", "孙明杰", 220, "谭睿诚", "新龙村" },
                    { new Guid("bece5423-64a4-456e-8f32-5f03ea06d95e"), "震阳路与双娄路交叉口", "320583106210", "0512-57421150", 5, 35, "320583106000", "贺博艺", 122, "冯鹏赋", "星金村" },
                    { new Guid("5f7ad0c4-85d1-4b54-8fe9-3b2f6a468361"), "盛巷花园门卫北侧", "320583106209", "0512-57441616", 5, 20, "320583106000", "韩华藏", 111, "萧泰河", "新塘村" },
                    { new Guid("54355e56-dffb-405a-a47b-fa80aee411d9"), "港浦东路8号", "320583106207", "0512-5736863220", 5, 33, "320583106000", "史光临", 111, "陈浦和", "三家村" },
                    { new Guid("269dd6f5-ec4b-4ee0-8105-009ad243f769"), "川浩路22号", "320583106206", "0512-57441101", 5, null, "320583106000", "丁弘亮", 220, "龚炎彬", "吴加村" },
                    { new Guid("399d103c-47e9-4b76-872b-f5bd1750df09"), "机场路与兴陵路交叉口往南200米", "320583106205", "0512-57441476", 5, 27, "320583106000", "邹俊雄", 220, "程飞虎", "赵陵村" },
                    { new Guid("4ee2c305-eadf-450e-ab03-237f7fae968c"), "商鞅路1号", "320583106204", "0512-50310612", 5, 20, "320583106000", "汤明亮", 112, "吴咏德", "七桥村" },
                    { new Guid("09c775d0-22c5-4dce-89a8-4b7439c91001"), "金华路1号", "320583106200", "0512-57293702", 5, 26, "320583106000", "宋翰学", 112, "龙昊焱", "金华村" },
                    { new Guid("6cdcbbe6-110c-439b-bc6d-df66574da26c"), "长江南路东侧与锦溪北交界", "320583106220", "0512-57256590", 5, 21, "320583106000", "汤英耀", 220, "蒋嘉许", "尚明甸村" },
                    { new Guid("4bae5d35-8a55-444c-ab99-b6fffdd610ef"), "振苏六村", "320583106003", "0512-55270465", 5, null, "320583106000", "廖景天", 111, "崔泰宁", "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("33feb476-b3c3-41e7-9370-ef89fd7395d0"), new Guid("667e1876-c225-4beb-b060-3391708a9398"), new Guid("4bcf8798-dd21-4bcd-b169-dbd01efa6c8a") },
                    { new Guid("6b476148-2a7f-4fbc-9f54-e07b4172f237"), new Guid("f7ebaae8-37cc-4eff-ab86-92ca58a9a597"), new Guid("4bcf8798-dd21-4bcd-b169-dbd01efa6c8a") },
                    { new Guid("8832bbc3-c00a-4a18-ad03-846a868c63ba"), new Guid("fa956970-367a-4d4d-ab84-78873ba1fbb1"), new Guid("af3677a1-fc12-401b-bbbe-e1eee13ac5cc") },
                    { new Guid("99e5aade-d140-47e7-9415-cb232cb5f018"), new Guid("fa956970-367a-4d4d-ab84-78873ba1fbb1"), new Guid("97b485b3-819b-4128-95fe-35a8074fa282") },
                    { new Guid("f4dd464c-23f5-4a12-9cd2-2c9655cca32b"), new Guid("667e1876-c225-4beb-b060-3391708a9398"), new Guid("303e6c31-59f2-421b-8470-6d51cf0ca30f") }
                });
        }
    }
}
