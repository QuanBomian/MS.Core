using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("32ca1125-91a4-4b52-bd73-e26a2f44a235"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3b19a093-730d-49aa-bf6b-040ef7c741d5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a6b4c1b2-c0c8-4cce-a10d-29dc3bbc2007"));

            migrationBuilder.DeleteData(
                table: "Families",
                keyColumn: "Id",
                keyValue: new Guid("6a620dac-dcb9-4d58-a5b1-5246526de87a"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("23f5be70-b309-4ff0-b069-9ada8c60f30c"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("6b7daded-2178-444d-91f1-5df57233db71"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("7fd36c16-03f5-41c1-bb2b-3c4d1eac7f0c"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("b8bed0c8-4bc6-4ab3-8abc-a1cb84d6adbd"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("f79f0c44-9707-4a5e-97f3-cd97394ce9d2"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("4b12f44a-bed1-4733-b8ca-c348b00f4221"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("9acf04c6-78f2-4cab-a77d-11d618183937"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("bd18b8a9-4b54-481a-bccf-fb612265ff8d"));

            migrationBuilder.DeleteData(
                table: "PartyMembers",
                keyColumn: "Id",
                keyValue: new Guid("030f20f9-be02-498e-b47b-94ab67c7829c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("119ddf8f-4003-4478-9548-b1f83568faa4"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("3166d1ef-c9e7-46f8-bbd9-82adff7d9a09"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4af5fe66-2e3b-485d-91c0-7c6e4529ad09"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("73106449-b26e-49ac-a588-dbc06ee25817"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a154bb0d-e29d-4e69-8319-ea9fb9975ce8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("b97d0fe6-24b4-44a6-84f3-3869db774e64"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bc4d9fe3-a53e-4398-b492-a8ba6a6d3cec"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c8f7419c-0117-4868-8172-0c79a77d4952"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("cc4b686f-2172-4e46-93f1-afcff9fd7e15"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ecc55693-b9d4-4fd6-8355-5a8955880883"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("05a5fe00-1642-41f9-b956-a21806339d0a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("090f83d5-52a7-4c5a-b20d-3ee5bcb3e641"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("166e8e93-aea5-4c3c-9362-501888916e6e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("17270b80-244b-4bc6-b3c3-40ca9900222d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("3081b6aa-aeb5-4f0d-8e7c-958d9b264e82"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("19dc037c-11db-49bb-92d2-16229996001f"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("27ad29ca-06e7-4900-9062-a8a208cebbd0"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("378969bc-a7c6-4a74-a8b4-9709b99d57c2"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("541d56b6-6b1f-49ca-a1f7-f13d842d4ac5"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("6d4b0a8a-61a4-4d45-9952-1e4c79066f5b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("7493686b-316f-41d5-a125-9460573de83b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("86826d1f-fff1-43df-884c-c7638664fab6"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("b878caca-d737-4eed-bde1-4484b3290a18"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("bc891b6a-b184-40b0-974a-75cf131e62f7"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("da86766e-8c62-4128-bbee-cc8fa94d3d5f"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("ebd6ddb3-bba5-49dc-ac64-a48b23df10f3"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("fc27bc0c-ed98-4db1-8aad-d3d388669184"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("5f6b15a6-c539-4ed9-9520-02710d677a49"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("a2a6ac89-9db1-4a3c-9896-6d414d8eb934"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("a5e91509-c051-4b23-b9ad-97004484d05c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("09dab23c-0cb4-4f11-a053-31c026db1090"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("0a1f479f-f2c3-4429-a303-6a8d5d7cc0eb"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1110d4ca-2c55-48ca-83a1-f1b805539a01"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1265a36c-e14e-45f7-b58b-306f4190bf9f"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("166788f5-14fe-4dae-a753-45b46dbae24a"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("177e6e4b-0dd9-456c-81a5-5dbc349a521c"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("387b9723-7b65-4448-a2e8-37d865b364b7"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("3e295d2a-5968-4d77-88a0-294f9aa7fe79"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("4141524c-5cbf-4d49-b14c-98fd78674a0d"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("488ffbae-9bc4-4b94-bb00-b4b305d4608b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("5b585085-5bad-49c0-834a-75817121c4e5"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("6345f6bf-0e3d-42fc-ad65-da6eb2db8e6d"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("706059c5-f49d-4cad-bfe9-21993c8e2262"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("707b92a8-9b42-4097-8761-0401d2707302"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("76bfeb4a-2274-4107-8470-af2e14cc8957"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("7d570fe8-f204-4eee-9e38-45a73129e6f1"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("8481e802-3f2f-4f34-9159-85c8d2c1dd45"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("856f336e-d104-4fa0-81f3-9a6abc1f14f0"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("95635789-ba53-493b-9ff1-c3410c6bcdcd"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("b302ebc1-70b8-4622-9d95-f0f8a499085d"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("b34a2825-b1be-4871-8ba4-7a39376ae765"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("bd423e53-b6f6-41ce-b60c-fa641eeecf0b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("be8b6c7b-e39a-4ec2-8eb5-aad1dc567c21"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("da4b4ebc-482a-4aa2-b936-60113f131e8d"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("e17c2811-7ab3-4c12-b076-139171fe4fba"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("ea4fbb28-9e60-401e-b618-0bf5a059173f"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("f594a916-d2a6-42aa-973e-0f220cde67a7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("674a42bd-6c58-4744-a5d2-148da2147bd5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a7429443-d8fa-49ef-8a1d-42656bd9b3d3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e9f15015-21ab-49e7-af9d-b0d204083c23"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5d4f21cd-9111-4917-acfe-a6f291171a76"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72bbb09e-d9c0-4f89-a622-378a1b6937fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8862719c-27b4-4218-925b-63cf50421927"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93b7b413-cde7-45bc-895e-3c05a0b95aff"));

            migrationBuilder.AlterColumn<string>(
                name: "VillageGroupCode",
                table: "VillagerGroups",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "ContactPhone", "DepartmentCode", "DepartmentName", "Email", "Fax", "Notes", "PrincipalName" },
                values: new object[,]
                {
                    { new Guid("916d1e13-a624-4c69-b1b5-f4c69bef7dd9"), "京东路469号", "0512-57623451", "001", "张浦社区党支部委员会", "zhenxinguo@kszpzp.gov.cn", "0512-54123412", "", "郑兴国" },
                    { new Guid("a28852f3-990b-4002-a3e2-3c976973fa2b"), "京东路469号", "0512-58289432", "002", "张浦社区居民委员会", "chenlecheng@kszpzp.gov.cn", "0512-59283414", "临时兼任", "陈乐成" },
                    { new Guid("00a97e6f-d988-4551-88a7-15288df6b8ea"), "花苑路与京东路交叉口西侧", "0512-54128123", "003", "花园社区党支部委员会", "xugaoyi@kszpzp.gov.cn", "0512-564178314", null, "许高义" }
                });

            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "AccountCharacter", "AverageAnnualIncome", "AverageHousingArea", "FamilyCode", "Householder", "HousingArea", "IsLowIncome", "IsPoor", "PeopleNumber", "VillageGroupCode", "VillageName" },
                values: new object[] { new Guid("799a6d80-9506-4ffa-b5df-4347b1d2d599"), "非农业", 5000, 20.84f, "001000", "秦博厚", 104.2f, false, false, 5, "001", null });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthday", "DepartmentCode", "Education", "EntryTime", "Gender", "HomeAddress", "IdCardNumber", "LeaveTime", "LengthOfService", "MaritalStatus", "MemberCode", "MemberName", "Nationality", "PersonnelNature", "PoliticalStatus", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("03a5b722-7e14-41a0-9cac-7b22fb5f4f09"), new DateTime(1979, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "硕士研究生", new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村12号", "320583197910154878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14年", "离异", "002003", "康志国", "汉族", null, "群众", "财经委员", "在职" },
                    { new Guid("7ccf6962-8734-4c39-bd7e-05c650752d32"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村14号", "320583197407056857", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002000", "陈乐成", "汉族", null, "中共党员", "主任", "在职" },
                    { new Guid("51861814-a3e9-4fef-a10e-85085b3e1a2d"), new DateTime(1977, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2002, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇浦江北新村112号", "320583197707087692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17年", "已婚", "002001", "姜兴安", "汉族", null, "中共党员", "副主任", "在职" },
                    { new Guid("8d7a0084-9ee9-4de6-bcf8-22ecef68ef84"), new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "高中", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村56号", "320583198504178937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9年", "丧偶", "002002", "于君昊", "汉族", null, "中共党员", "治调委员", "在职" },
                    { new Guid("daf4d636-c213-495f-8035-72255bd3fcac"), new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "女", "张浦镇江北新村17号", "320583198704187965", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002004", "赵陈红", "汉族", null, "群众", "妇女计生委员", "在职" }
                });

            migrationBuilder.InsertData(
                table: "NonOperatingAssets",
                columns: new[] { "Id", "LibaryCollectionsNumber", "LibraryNumber", "OfficeBuildingArea", "OfficeBuildingNumber", "SeniorCitizenCenterArea", "SeniorCitizenCenterNumber", "ServiceStationNumber", "SportActivityRoomArea", "SportsActivityRoomNumber", "StaffQuarterArea", "StaffQuartersNumber", "VillageName" },
                values: new object[,]
                {
                    { new Guid("8ea96382-47eb-463f-990c-420526ff0c24"), 3000, 1, 105f, 1, 450f, 1, 4, 1000f, 2, 1000f, 1, "张浦社区" },
                    { new Guid("f4bf71f4-c696-4a90-927d-1afc03765738"), 2500, 1, 172f, 1, 380f, 1, 2, 800f, 1, 1200f, 1, "花园社区" },
                    { new Guid("1d26ae2d-6974-4a16-b323-1ca5ad24b038"), 5000, 1, 250f, 2, 700f, 2, 1, 1500f, 3, 2000f, 2, "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "PartyMembers",
                columns: new[] { "Id", "Birthday", "ContactPhone", "DepartmentCode", "Education", "Gender", "IsFullMember", "MemberCode", "Nationality", "PartyMemberName", "PartyOrganizationName", "PartyPosition", "VillageName" },
                values: new object[] { new Guid("24074bf0-430e-44f4-9678-6085811d95a6"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "13057134712", "001", "本科", "男", true, "001000", "汉族", "陈乐成", "张浦社区党支部委员会", "无", "张浦社区" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("b1edf7db-ee81-4f2b-be54-20b637caa3b4"), "System" },
                    { new Guid("783d3395-1764-418a-9772-f3fa207bc8f6"), "Admin" },
                    { new Guid("e01a243f-c285-42eb-aec1-ae5d99e6c020"), "Client" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "AreaNumber", "ChairmanName", "ContactPhone", "GovernmentLevel", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("ed072c74-cbc9-4cf4-b393-98821cfb8b3d"), "淀南路100号", "320583107000", "陆先", "0521-57211236", 4, "王翱桦", "江衷力", "周庄镇" },
                    { new Guid("4632e465-df78-466e-91a1-d05478ea856e"), "府前路78号", "320583105000", "常般业", "0512-57488358", 4, "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("6b21cf9f-16d3-4b8a-8d56-545335ad96c3"), "普庆路1号", "320583109000", "邹鉴夕", "0521-57231290", 4, "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("96dc9fb4-ccc9-492a-a68d-9618d3c5abf3"), "炎东路", "320583108000", "林修胜", "0512-36620396", 4, "张弥成", "时可北", "千灯镇" },
                    { new Guid("1236c799-6ba8-4247-8575-490181b097f7"), "新澄路918号", "320583101000", "周伟", "0521-57656330", 4, "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("a64b7d5e-a89c-4796-9af9-7aaf1e15ee90"), "菉溪路22号", "	320583103000", "李迪尉", "0512-57671003", 4, "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("a3da34d8-5fb9-4b50-b427-38f3e1ddb4aa"), "前进东路", "320583400000", "邢栋祥", "0512-57329416", 4, "逢建德", "匡俊智", "开发区" },
                    { new Guid("e6081eda-a460-4f83-b349-3a7130c835e5"), "花溪路358号", "320583104000", "武财章", "0512-57698733", 4, "王班", "吴启河", "花桥镇" },
                    { new Guid("cf1a317a-e2c2-46ab-8412-619f3f3ed66e"), "前进西路168号", "320583102000", "祖冲之", "0512-57621053", 4, "陆机", "陆云", "周市镇" },
                    { new Guid("f3042800-7c4e-42a7-9f33-fb54d695b0dc"), "华杨路188号", "320583106000", "成梦昆", "0512-57452503", 4, "刘赫伯", "蒋信迟", "张浦镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("2b657f37-604f-4096-b756-ff49b644247b"), "admin", "admin" },
                    { new Guid("c03c25a1-dfc4-4d46-b1b5-9d10123655c7"), "user1", "user1" },
                    { new Guid("28ea152c-79d7-450e-b6ae-1e108834fa40"), "user2", "user2" },
                    { new Guid("3384518d-4d76-4b7a-83bc-8d779cffa458"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "VillagerGroups",
                columns: new[] { "Id", "MemberNumber", "PrincipalAddress", "PrincipalEmail", "PrincipalName", "PrincipalPhone", "VillageGroupCode", "VillageName" },
                values: new object[,]
                {
                    { new Guid("90aced48-9ed4-4e89-9916-586c225f6f02"), 512, "张浦镇风和日丽5幢1102室", "qianyancheng@kszpfhrl.gov.cn", "钱阳成", null, "005", "南港社区" },
                    { new Guid("48fbdb51-d344-4a4f-bf71-ce3cc8afcda1"), 567, "张浦镇枫情佳苑3幢306室", "kongzhiwen@kszpfqjy.gov.cn", "孔志文", null, "006", "新吴社区" },
                    { new Guid("4039ff64-9702-441d-9bd3-7db2c33abb7a"), 253, "张浦镇富仁小区5幢102室", "changgaohan@kszpfr.gov.cn", "常高翰", null, "004", "大市社区" },
                    { new Guid("0aa95d1a-1289-471d-8d94-36e295f92977"), 532, "张浦镇茶风新村1幢206室", "caogao@kszpcf.gov.cn", "蔡高", null, "003", "花园社区" },
                    { new Guid("4674bedd-3f42-4dfb-9ad8-d34fd80d16bc"), 341, "张浦镇江南春堤14号", "jiatianzong@kszpjnkd.gov.cn", "贾天纵", null, "011", "新巷社区" },
                    { new Guid("f70c92ba-da8a-45cf-888d-5189d275e26a"), 543, "张浦镇安居小区24号", "duanxuehai@kszpanxq.gov.cn", "段学海", null, "012", "大市社区" },
                    { new Guid("3f40ba31-a05e-4ce2-836e-fe7cb2ace6ef"), 345, "张浦镇张浦村142号", "xuexiuxian@kszpzp.gov.cn", "薛修贤", null, "008", "张浦社区" },
                    { new Guid("e601acd2-ac71-4ac1-a375-a08591cf3d2b"), 412, "张浦镇富都新村3幢204室", "fangjitong@kszpfd.gov.cn", "方季同", null, "002", "南港社区" },
                    { new Guid("d07b4e7d-8052-487f-9242-e5dd95ab03c2"), 452, "张浦镇银鹿新城3幢802室", "heliren@kszpylxc.gov.cn", "何立人", null, "009", "张浦社区" },
                    { new Guid("c83c284e-4308-468f-921b-0665af8860fa"), 662, "张浦镇牡丹苑7幢502", "zhongjunde@kszpmdy.gov.cn", "钟俊德", null, "010", "周巷社区" },
                    { new Guid("892792a7-d98a-4fc7-b22f-d18b31047bfb"), 476, "张浦镇张浦村14号", "huhaorang@kszpzp.gov.cn", "胡浩壤", null, "007", "张浦社区" },
                    { new Guid("8d02e443-ff83-4182-b91e-d5893d5c9b00"), 356, "张浦镇望江新村6幢206室", "wuxuefei@kszpwz.gov.cn", "吴雪峰", "0512-57841234", "001", "南港社区" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("7373f677-89db-44cf-8339-893412f86e0f"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" },
                    { new Guid("be4bf72f-bbcf-445a-9f5e-3076195f98cc"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("6f95e111-da15-49b5-906d-8431705a9dd8"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Address", "AreaNumber", "ContactPhone", "GovernmentLevel", "GroupCount", "SecretaryName", "UrbanRuralClassification", "VillageHeadName", "VillageName" },
                values: new object[,]
                {
                    { new Guid("0a1adf95-ff42-43d8-84bd-51e24e49b889"), "京东路731号", "320583106013", "0512-57278938", 5, null, "李段", 111, "吕尊", "锦和社区" },
                    { new Guid("cfa29fec-d824-4099-abc6-c3b432963b88"), "京东路469号", "320583106001", "0512-57441175", 5, 12, "尹乐和", 111, "赵乐欣", "张浦社区" },
                    { new Guid("99172a1a-5733-4371-9cdf-3dd4c105f964"), "花苑路与京东路交叉口西侧", "320583106002", "0512-36863123", 5, 26, "汤振海", 111, "杜向阳", "花园社区" },
                    { new Guid("5a1d5282-cda7-43bb-8498-8c72814d71ac"), "震阳路126号", "320583106004", "0512-57428835", 5, null, "阎乐池", 121, "尹和蔼", "南港社区" },
                    { new Guid("c7d55d8a-561c-4ac9-bcf8-1894a29d9884"), "淞沪西路36号", "320583106005", "0512-57256550", 5, null, "许宏畅", 220, "薛兴为", "大市社区" },
                    { new Guid("da5fcc37-1c12-4564-ac1e-f5ccdd0749a2"), "俱巷路894号", "320583106006", "0512-36691258", 5, null, "孔浩思", 111, "王康胜", "新巷社区" },
                    { new Guid("cccebd52-6016-4205-b6a2-a1848fc6ed80"), "商秧路178号", "320583106007", "0512-55272500", 5, 26, "吴俊晤", 111, "石欣德", "新吴社区" },
                    { new Guid("f55d94b3-372e-4c4b-a82e-3c4922239dda"), "大直路504号", "320583106008", "0512-55272500", 5, 23, "梁奇希", 112, "吕勇男", "大直社区" },
                    { new Guid("5ddf5806-4a1c-454d-bf79-a84bd650efb2"), "周巷路", "320583106009", "0512-57294577", 5, 40, "姜永昌", 111, "吴凯凯", "周巷社区" },
                    { new Guid("af26698b-d4d9-4111-b47c-106805e25562"), "淞沪东路12号", "320583106227", "0512-57251131", 5, null, "朱嘉石", 220, "顾飞羽", "南吉山村" },
                    { new Guid("05b92add-e539-4b6b-849d-913691dbb515"), "淞沪西路与江浦南路交叉口", "320583106226", "0512-57255236", 5, 49, "顾绍祺", 220, "金和怡", "大市村" },
                    { new Guid("c71241be-0e4b-4c35-a64f-b44dd37e0b0b"), "京东路588号", "320583106012", "0512-57883298", 5, null, "龙澔", 111, "汤烨磊", "亲和社区" },
                    { new Guid("9339a3a6-ae1f-453c-a204-7a8d1e027da5"), "姚家港北首", "320583106221", "0512-57117756", 5, 22, "杨成仁", 220, "谢高义", "南姚村" },
                    { new Guid("43d3421a-96ca-456f-b79e-94beb8d5258b"), "江浦南路与C325交叉处", "320583106219", "0512-57272133", 5, 23, "漕文彦", 220, "许高岑", "姜杭村" },
                    { new Guid("2c25a9c0-3fd1-4e52-b96b-fd96d46600ac"), "安头村公交站台往南60米处", "320583106215", "0512-57428927", 5, 25, "郝嘉慕", 220, "史意蕴", "安头村" },
                    { new Guid("1df02b11-599c-478b-a7a4-759ff0faf9e9"), "南港文体站", "320583106214", "0512-57428327", 5, 28, "蒋英卓", 220, "冯兴庆", "林庄村" },
                    { new Guid("784885d6-3736-4708-893f-825058ae2539"), "建林路往北到底向西100米", "320583106212", "0512-57120550", 5, null, "万安怡", 220, "萧波峻", "白米村" },
                    { new Guid("b2522ddf-f62f-4b62-aa17-9e19d0d3de2b"), "陈邱家浜58号", "320583106211", "0512-50331469", 5, 44, "孙明杰", 220, "谭睿诚", "新龙村" },
                    { new Guid("f0443a35-d67b-4ba6-8137-50c6c2f3f934"), "震阳路与双娄路交叉口", "320583106210", "0512-57421150", 5, 35, "贺博艺", 122, "冯鹏赋", "星金村" },
                    { new Guid("1b243d46-9503-4b28-a5d7-6d3c3248abec"), "盛巷花园门卫北侧", "320583106209", "0512-57441616", 5, 20, "韩华藏", 111, "萧泰河", "新塘村" },
                    { new Guid("c8f50c7b-6459-419a-85c1-fbe8e577e3da"), "港浦东路8号", "320583106207", "0512-5736863220", 5, 33, "史光临", 111, "陈浦和", "三家村" },
                    { new Guid("198f26ac-f56f-49fe-ba86-e0f7b31e9725"), "川浩路22号", "320583106206", "0512-57441101", 5, null, "丁弘亮", 220, "龚炎彬", "吴加村" },
                    { new Guid("d479b7ff-3842-4164-b400-b73ae1fcfef7"), "机场路与兴陵路交叉口往南200米", "320583106205", "0512-57441476", 5, 27, "邹俊雄", 220, "程飞虎", "赵陵村" },
                    { new Guid("ec305b9a-9415-41e9-92c0-2cdcc54b5ae8"), "商鞅路1号", "320583106204", "0512-50310612", 5, 20, "汤明亮", 112, "吴咏德", "七桥村" },
                    { new Guid("185c86e6-54fd-4fb7-8700-02cce1e144b0"), "金华路1号", "320583106200", "0512-57293702", 5, 26, "宋翰学", 112, "龙昊焱", "金华村" },
                    { new Guid("62fdf56c-b79b-466b-9a25-bf6ad868e6ed"), "长江南路东侧与锦溪北交界", "320583106220", "0512-57256590", 5, 21, "汤英耀", 220, "蒋嘉许", "尚明甸村" },
                    { new Guid("06b40a0b-f476-4913-b02b-135ab2be8892"), "振苏六村", "320583106003", "0512-55270465", 5, null, "廖景天", 111, "崔泰宁", "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6b027a24-3c05-4383-bd9e-67217e52b62f"), new Guid("783d3395-1764-418a-9772-f3fa207bc8f6"), new Guid("2b657f37-604f-4096-b756-ff49b644247b") },
                    { new Guid("af0a8560-9acc-44df-87f7-91538fbd4f26"), new Guid("b1edf7db-ee81-4f2b-be54-20b637caa3b4"), new Guid("2b657f37-604f-4096-b756-ff49b644247b") },
                    { new Guid("5cc834bc-8237-481c-bd21-f1960c90f052"), new Guid("e01a243f-c285-42eb-aec1-ae5d99e6c020"), new Guid("c03c25a1-dfc4-4d46-b1b5-9d10123655c7") },
                    { new Guid("72e9682e-6b22-400d-9715-66324ee58c8c"), new Guid("e01a243f-c285-42eb-aec1-ae5d99e6c020"), new Guid("28ea152c-79d7-450e-b6ae-1e108834fa40") },
                    { new Guid("6ff030b3-aa06-44be-bb6c-cc15782075a3"), new Guid("783d3395-1764-418a-9772-f3fa207bc8f6"), new Guid("3384518d-4d76-4b7a-83bc-8d779cffa458") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("00a97e6f-d988-4551-88a7-15288df6b8ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("916d1e13-a624-4c69-b1b5-f4c69bef7dd9"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("a28852f3-990b-4002-a3e2-3c976973fa2b"));

            migrationBuilder.DeleteData(
                table: "Families",
                keyColumn: "Id",
                keyValue: new Guid("799a6d80-9506-4ffa-b5df-4347b1d2d599"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("03a5b722-7e14-41a0-9cac-7b22fb5f4f09"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("51861814-a3e9-4fef-a10e-85085b3e1a2d"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("7ccf6962-8734-4c39-bd7e-05c650752d32"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("8d7a0084-9ee9-4de6-bcf8-22ecef68ef84"));

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: new Guid("daf4d636-c213-495f-8035-72255bd3fcac"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("1d26ae2d-6974-4a16-b323-1ca5ad24b038"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("8ea96382-47eb-463f-990c-420526ff0c24"));

            migrationBuilder.DeleteData(
                table: "NonOperatingAssets",
                keyColumn: "Id",
                keyValue: new Guid("f4bf71f4-c696-4a90-927d-1afc03765738"));

            migrationBuilder.DeleteData(
                table: "PartyMembers",
                keyColumn: "Id",
                keyValue: new Guid("24074bf0-430e-44f4-9678-6085811d95a6"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1236c799-6ba8-4247-8575-490181b097f7"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4632e465-df78-466e-91a1-d05478ea856e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("6b21cf9f-16d3-4b8a-8d56-545335ad96c3"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("96dc9fb4-ccc9-492a-a68d-9618d3c5abf3"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a3da34d8-5fb9-4b50-b427-38f3e1ddb4aa"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a64b7d5e-a89c-4796-9af9-7aaf1e15ee90"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("cf1a317a-e2c2-46ab-8412-619f3f3ed66e"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e6081eda-a460-4f83-b349-3a7130c835e5"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ed072c74-cbc9-4cf4-b393-98821cfb8b3d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("f3042800-7c4e-42a7-9f33-fb54d695b0dc"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("5cc834bc-8237-481c-bd21-f1960c90f052"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6b027a24-3c05-4383-bd9e-67217e52b62f"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("6ff030b3-aa06-44be-bb6c-cc15782075a3"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("72e9682e-6b22-400d-9715-66324ee58c8c"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("af0a8560-9acc-44df-87f7-91538fbd4f26"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("0aa95d1a-1289-471d-8d94-36e295f92977"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("3f40ba31-a05e-4ce2-836e-fe7cb2ace6ef"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("4039ff64-9702-441d-9bd3-7db2c33abb7a"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("4674bedd-3f42-4dfb-9ad8-d34fd80d16bc"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("48fbdb51-d344-4a4f-bf71-ce3cc8afcda1"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("892792a7-d98a-4fc7-b22f-d18b31047bfb"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("8d02e443-ff83-4182-b91e-d5893d5c9b00"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("90aced48-9ed4-4e89-9916-586c225f6f02"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("c83c284e-4308-468f-921b-0665af8860fa"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("d07b4e7d-8052-487f-9242-e5dd95ab03c2"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("e601acd2-ac71-4ac1-a375-a08591cf3d2b"));

            migrationBuilder.DeleteData(
                table: "VillagerGroups",
                keyColumn: "Id",
                keyValue: new Guid("f70c92ba-da8a-45cf-888d-5189d275e26a"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("6f95e111-da15-49b5-906d-8431705a9dd8"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("7373f677-89db-44cf-8339-893412f86e0f"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("be4bf72f-bbcf-445a-9f5e-3076195f98cc"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("05b92add-e539-4b6b-849d-913691dbb515"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("06b40a0b-f476-4913-b02b-135ab2be8892"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("0a1adf95-ff42-43d8-84bd-51e24e49b889"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("185c86e6-54fd-4fb7-8700-02cce1e144b0"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("198f26ac-f56f-49fe-ba86-e0f7b31e9725"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1b243d46-9503-4b28-a5d7-6d3c3248abec"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("1df02b11-599c-478b-a7a4-759ff0faf9e9"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("2c25a9c0-3fd1-4e52-b96b-fd96d46600ac"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("43d3421a-96ca-456f-b79e-94beb8d5258b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("5a1d5282-cda7-43bb-8498-8c72814d71ac"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("5ddf5806-4a1c-454d-bf79-a84bd650efb2"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("62fdf56c-b79b-466b-9a25-bf6ad868e6ed"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("784885d6-3736-4708-893f-825058ae2539"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("9339a3a6-ae1f-453c-a204-7a8d1e027da5"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("99172a1a-5733-4371-9cdf-3dd4c105f964"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("af26698b-d4d9-4111-b47c-106805e25562"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("b2522ddf-f62f-4b62-aa17-9e19d0d3de2b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("c71241be-0e4b-4c35-a64f-b44dd37e0b0b"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("c7d55d8a-561c-4ac9-bcf8-1894a29d9884"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("c8f50c7b-6459-419a-85c1-fbe8e577e3da"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("cccebd52-6016-4205-b6a2-a1848fc6ed80"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("cfa29fec-d824-4099-abc6-c3b432963b88"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("d479b7ff-3842-4164-b400-b73ae1fcfef7"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("da5fcc37-1c12-4564-ac1e-f5ccdd0749a2"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("ec305b9a-9415-41e9-92c0-2cdcc54b5ae8"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("f0443a35-d67b-4ba6-8137-50c6c2f3f934"));

            migrationBuilder.DeleteData(
                table: "Villages",
                keyColumn: "Id",
                keyValue: new Guid("f55d94b3-372e-4c4b-a82e-3c4922239dda"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("783d3395-1764-418a-9772-f3fa207bc8f6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b1edf7db-ee81-4f2b-be54-20b637caa3b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e01a243f-c285-42eb-aec1-ae5d99e6c020"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28ea152c-79d7-450e-b6ae-1e108834fa40"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2b657f37-604f-4096-b756-ff49b644247b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3384518d-4d76-4b7a-83bc-8d779cffa458"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c03c25a1-dfc4-4d46-b1b5-9d10123655c7"));

            migrationBuilder.AlterColumn<int>(
                name: "VillageGroupCode",
                table: "VillagerGroups",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Address", "ContactPhone", "DepartmentCode", "DepartmentName", "Email", "Fax", "Notes", "PrincipalName" },
                values: new object[,]
                {
                    { new Guid("a6b4c1b2-c0c8-4cce-a10d-29dc3bbc2007"), "京东路469号", "0512-57623451", "001", "张浦社区党支部委员会", "zhenxinguo@kszpzp.gov.cn", "0512-54123412", "", "郑兴国" },
                    { new Guid("3b19a093-730d-49aa-bf6b-040ef7c741d5"), "京东路469号", "0512-58289432", "002", "张浦社区居民委员会", "chenlecheng@kszpzp.gov.cn", "0512-59283414", "临时兼任", "陈乐成" },
                    { new Guid("32ca1125-91a4-4b52-bd73-e26a2f44a235"), "花苑路与京东路交叉口西侧", "0512-54128123", "003", "花园社区党支部委员会", "xugaoyi@kszpzp.gov.cn", "0512-564178314", null, "许高义" }
                });

            migrationBuilder.InsertData(
                table: "Families",
                columns: new[] { "Id", "AccountCharacter", "AverageAnnualIncome", "AverageHousingArea", "FamilyCode", "Householder", "HousingArea", "IsLowIncome", "IsPoor", "PeopleNumber", "VillageGroupCode", "VillageName" },
                values: new object[] { new Guid("6a620dac-dcb9-4d58-a5b1-5246526de87a"), "非农业", 5000, 20.84f, "001000", "秦博厚", 104.2f, false, false, 5, "001", null });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Birthday", "DepartmentCode", "Education", "EntryTime", "Gender", "HomeAddress", "IdCardNumber", "LeaveTime", "LengthOfService", "MaritalStatus", "MemberCode", "MemberName", "Nationality", "PersonnelNature", "PoliticalStatus", "Position", "Status" },
                values: new object[,]
                {
                    { new Guid("6b7daded-2178-444d-91f1-5df57233db71"), new DateTime(1979, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "硕士研究生", new DateTime(2005, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村12号", "320583197910154878", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "14年", "离异", "002003", "康志国", "汉族", null, "群众", "财经委员", "在职" },
                    { new Guid("7fd36c16-03f5-41c1-bb2b-3c4d1eac7f0c"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村14号", "320583197407056857", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002000", "陈乐成", "汉族", null, "中共党员", "主任", "在职" },
                    { new Guid("b8bed0c8-4bc6-4ab3-8abc-a1cb84d6adbd"), new DateTime(1977, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2002, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇浦江北新村112号", "320583197707087692", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "17年", "已婚", "002001", "姜兴安", "汉族", null, "中共党员", "副主任", "在职" },
                    { new Guid("23f5be70-b309-4ff0-b069-9ada8c60f30c"), new DateTime(1985, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "高中", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "男", "张浦镇江北新村56号", "320583198504178937", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9年", "丧偶", "002002", "于君昊", "汉族", null, "中共党员", "治调委员", "在职" },
                    { new Guid("f79f0c44-9707-4a5e-97f3-cd97394ce9d2"), new DateTime(1987, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "002", "本科", new DateTime(2007, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "女", "张浦镇江北新村17号", "320583198704187965", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "12年", "已婚", "002004", "赵陈红", "汉族", null, "群众", "妇女计生委员", "在职" }
                });

            migrationBuilder.InsertData(
                table: "NonOperatingAssets",
                columns: new[] { "Id", "LibaryCollectionsNumber", "LibraryNumber", "OfficeBuildingArea", "OfficeBuildingNumber", "SeniorCitizenCenterArea", "SeniorCitizenCenterNumber", "ServiceStationNumber", "SportActivityRoomArea", "SportsActivityRoomNumber", "StaffQuarterArea", "StaffQuartersNumber", "VillageName" },
                values: new object[,]
                {
                    { new Guid("9acf04c6-78f2-4cab-a77d-11d618183937"), 3000, 1, 105f, 1, 450f, 1, 4, 1000f, 2, 1000f, 1, "张浦社区" },
                    { new Guid("4b12f44a-bed1-4733-b8ca-c348b00f4221"), 2500, 1, 172f, 1, 380f, 1, 2, 800f, 1, 1200f, 1, "花园社区" },
                    { new Guid("bd18b8a9-4b54-481a-bccf-fb612265ff8d"), 5000, 1, 250f, 2, 700f, 2, 1, 1500f, 3, 2000f, 2, "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "PartyMembers",
                columns: new[] { "Id", "Birthday", "ContactPhone", "DepartmentCode", "Education", "Gender", "IsFullMember", "MemberCode", "Nationality", "PartyMemberName", "PartyOrganizationName", "PartyPosition", "VillageName" },
                values: new object[] { new Guid("030f20f9-be02-498e-b47b-94ab67c7829c"), new DateTime(1974, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "13057134712", "001", "本科", "男", true, "001000", "汉族", "陈乐成", "张浦社区党支部委员会", "无", "张浦社区" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("674a42bd-6c58-4744-a5d2-148da2147bd5"), "System" },
                    { new Guid("a7429443-d8fa-49ef-8a1d-42656bd9b3d3"), "Admin" },
                    { new Guid("e9f15015-21ab-49e7-af9d-b0d204083c23"), "Client" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "AreaNumber", "ChairmanName", "ContactPhone", "GovernmentLevel", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("b97d0fe6-24b4-44a6-84f3-3869db774e64"), "淀南路100号", "320583107000", "陆先", "0521-57211236", 4, "王翱桦", "江衷力", "周庄镇" },
                    { new Guid("a154bb0d-e29d-4e69-8319-ea9fb9975ce8"), "府前路78号", "320583105000", "常般业", "0512-57488358", 4, "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("ecc55693-b9d4-4fd6-8355-5a8955880883"), "普庆路1号", "320583109000", "邹鉴夕", "0521-57231290", 4, "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("4af5fe66-2e3b-485d-91c0-7c6e4529ad09"), "炎东路", "320583108000", "林修胜", "0512-36620396", 4, "张弥成", "时可北", "千灯镇" },
                    { new Guid("119ddf8f-4003-4478-9548-b1f83568faa4"), "新澄路918号", "320583101000", "周伟", "0521-57656330", 4, "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("3166d1ef-c9e7-46f8-bbd9-82adff7d9a09"), "菉溪路22号", "	320583103000", "李迪尉", "0512-57671003", 4, "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("c8f7419c-0117-4868-8172-0c79a77d4952"), "前进东路", "320583400000", "邢栋祥", "0512-57329416", 4, "逢建德", "匡俊智", "开发区" },
                    { new Guid("73106449-b26e-49ac-a588-dbc06ee25817"), "花溪路358号", "320583104000", "武财章", "0512-57698733", 4, "王班", "吴启河", "花桥镇" },
                    { new Guid("cc4b686f-2172-4e46-93f1-afcff9fd7e15"), "前进西路168号", "320583102000", "祖冲之", "0512-57621053", 4, "陆机", "陆云", "周市镇" },
                    { new Guid("bc4d9fe3-a53e-4398-b492-a8ba6a6d3cec"), "华杨路188号", "320583106000", "成梦昆", "0512-57452503", 4, "刘赫伯", "蒋信迟", "张浦镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("8862719c-27b4-4218-925b-63cf50421927"), "admin", "admin" },
                    { new Guid("5d4f21cd-9111-4917-acfe-a6f291171a76"), "user1", "user1" },
                    { new Guid("93b7b413-cde7-45bc-895e-3c05a0b95aff"), "user2", "user2" },
                    { new Guid("72bbb09e-d9c0-4f89-a622-378a1b6937fb"), "user3", "user3" }
                });

            migrationBuilder.InsertData(
                table: "VillagerGroups",
                columns: new[] { "Id", "MemberNumber", "PrincipalAddress", "PrincipalEmail", "PrincipalName", "PrincipalPhone", "VillageGroupCode", "VillageName" },
                values: new object[,]
                {
                    { new Guid("ebd6ddb3-bba5-49dc-ac64-a48b23df10f3"), 512, "张浦镇风和日丽5幢1102室", "qianyancheng@kszpfhrl.gov.cn", "钱阳成", null, 5, "南港社区" },
                    { new Guid("7493686b-316f-41d5-a125-9460573de83b"), 567, "张浦镇枫情佳苑3幢306室", "kongzhiwen@kszpfqjy.gov.cn", "孔志文", null, 6, "新吴社区" },
                    { new Guid("da86766e-8c62-4128-bbee-cc8fa94d3d5f"), 253, "张浦镇富仁小区5幢102室", "changgaohan@kszpfr.gov.cn", "常高翰", null, 4, "大市社区" },
                    { new Guid("19dc037c-11db-49bb-92d2-16229996001f"), 532, "张浦镇茶风新村1幢206室", "caogao@kszpcf.gov.cn", "蔡高", null, 3, "花园社区" },
                    { new Guid("27ad29ca-06e7-4900-9062-a8a208cebbd0"), 341, "张浦镇江南春堤14号", "jiatianzong@kszpjnkd.gov.cn", "贾天纵", null, 11, "新巷社区" },
                    { new Guid("fc27bc0c-ed98-4db1-8aad-d3d388669184"), 543, "张浦镇安居小区24号", "duanxuehai@kszpanxq.gov.cn", "段学海", null, 12, "大市社区" },
                    { new Guid("541d56b6-6b1f-49ca-a1f7-f13d842d4ac5"), 345, "张浦镇张浦村142号", "xuexiuxian@kszpzp.gov.cn", "薛修贤", null, 8, "张浦社区" },
                    { new Guid("86826d1f-fff1-43df-884c-c7638664fab6"), 412, "张浦镇富都新村3幢204室", "fangjitong@kszpfd.gov.cn", "方季同", null, 2, "南港社区" },
                    { new Guid("b878caca-d737-4eed-bde1-4484b3290a18"), 452, "张浦镇银鹿新城3幢802室", "heliren@kszpylxc.gov.cn", "何立人", null, 9, "张浦社区" },
                    { new Guid("6d4b0a8a-61a4-4d45-9952-1e4c79066f5b"), 662, "张浦镇牡丹苑7幢502", "zhongjunde@kszpmdy.gov.cn", "钟俊德", null, 10, "周巷社区" },
                    { new Guid("bc891b6a-b184-40b0-974a-75cf131e62f7"), 476, "张浦镇张浦村14号", "huhaorang@kszpzp.gov.cn", "胡浩壤", null, 7, "张浦社区" },
                    { new Guid("378969bc-a7c6-4a74-a8b4-9709b99d57c2"), 356, "张浦镇望江新村6幢206室", "wuxuefei@kszpwz.gov.cn", "吴雪峰", "0512-57841234", 1, "南港社区" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("a2a6ac89-9db1-4a3c-9896-6d414d8eb934"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" },
                    { new Guid("a5e91509-c051-4b23-b9ad-97004484d05c"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" },
                    { new Guid("5f6b15a6-c539-4ed9-9520-02710d677a49"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Address", "AreaNumber", "ContactPhone", "GovernmentLevel", "GroupCount", "SecretaryName", "UrbanRuralClassification", "VillageHeadName", "VillageName" },
                values: new object[,]
                {
                    { new Guid("3e295d2a-5968-4d77-88a0-294f9aa7fe79"), "京东路731号", "320583106013", "0512-57278938", 5, null, "李段", 111, "吕尊", "锦和社区" },
                    { new Guid("f594a916-d2a6-42aa-973e-0f220cde67a7"), "京东路469号", "320583106001", "0512-57441175", 5, 12, "尹乐和", 111, "赵乐欣", "张浦社区" },
                    { new Guid("e17c2811-7ab3-4c12-b076-139171fe4fba"), "花苑路与京东路交叉口西侧", "320583106002", "0512-36863123", 5, 26, "汤振海", 111, "杜向阳", "花园社区" },
                    { new Guid("ea4fbb28-9e60-401e-b618-0bf5a059173f"), "震阳路126号", "320583106004", "0512-57428835", 5, null, "阎乐池", 121, "尹和蔼", "南港社区" },
                    { new Guid("6345f6bf-0e3d-42fc-ad65-da6eb2db8e6d"), "淞沪西路36号", "320583106005", "0512-57256550", 5, null, "许宏畅", 220, "薛兴为", "大市社区" },
                    { new Guid("95635789-ba53-493b-9ff1-c3410c6bcdcd"), "俱巷路894号", "320583106006", "0512-36691258", 5, null, "孔浩思", 111, "王康胜", "新巷社区" },
                    { new Guid("706059c5-f49d-4cad-bfe9-21993c8e2262"), "商秧路178号", "320583106007", "0512-55272500", 5, 26, "吴俊晤", 111, "石欣德", "新吴社区" },
                    { new Guid("da4b4ebc-482a-4aa2-b936-60113f131e8d"), "大直路504号", "320583106008", "0512-55272500", 5, 23, "梁奇希", 112, "吕勇男", "大直社区" },
                    { new Guid("b34a2825-b1be-4871-8ba4-7a39376ae765"), "周巷路", "320583106009", "0512-57294577", 5, 40, "姜永昌", 111, "吴凯凯", "周巷社区" },
                    { new Guid("387b9723-7b65-4448-a2e8-37d865b364b7"), "淞沪东路12号", "320583106227", "0512-57251131", 5, null, "朱嘉石", 220, "顾飞羽", "南吉山村" },
                    { new Guid("5b585085-5bad-49c0-834a-75817121c4e5"), "淞沪西路与江浦南路交叉口", "320583106226", "0512-57255236", 5, 49, "顾绍祺", 220, "金和怡", "大市村" },
                    { new Guid("76bfeb4a-2274-4107-8470-af2e14cc8957"), "京东路588号", "320583106012", "0512-57883298", 5, null, "龙澔", 111, "汤烨磊", "亲和社区" },
                    { new Guid("4141524c-5cbf-4d49-b14c-98fd78674a0d"), "姚家港北首", "320583106221", "0512-57117756", 5, 22, "杨成仁", 220, "谢高义", "南姚村" },
                    { new Guid("1265a36c-e14e-45f7-b58b-306f4190bf9f"), "江浦南路与C325交叉处", "320583106219", "0512-57272133", 5, 23, "漕文彦", 220, "许高岑", "姜杭村" },
                    { new Guid("0a1f479f-f2c3-4429-a303-6a8d5d7cc0eb"), "安头村公交站台往南60米处", "320583106215", "0512-57428927", 5, 25, "郝嘉慕", 220, "史意蕴", "安头村" },
                    { new Guid("856f336e-d104-4fa0-81f3-9a6abc1f14f0"), "南港文体站", "320583106214", "0512-57428327", 5, 28, "蒋英卓", 220, "冯兴庆", "林庄村" },
                    { new Guid("be8b6c7b-e39a-4ec2-8eb5-aad1dc567c21"), "建林路往北到底向西100米", "320583106212", "0512-57120550", 5, null, "万安怡", 220, "萧波峻", "白米村" },
                    { new Guid("7d570fe8-f204-4eee-9e38-45a73129e6f1"), "陈邱家浜58号", "320583106211", "0512-50331469", 5, 44, "孙明杰", 220, "谭睿诚", "新龙村" },
                    { new Guid("488ffbae-9bc4-4b94-bb00-b4b305d4608b"), "震阳路与双娄路交叉口", "320583106210", "0512-57421150", 5, 35, "贺博艺", 122, "冯鹏赋", "星金村" },
                    { new Guid("09dab23c-0cb4-4f11-a053-31c026db1090"), "盛巷花园门卫北侧", "320583106209", "0512-57441616", 5, 20, "韩华藏", 111, "萧泰河", "新塘村" },
                    { new Guid("166788f5-14fe-4dae-a753-45b46dbae24a"), "港浦东路8号", "320583106207", "0512-5736863220", 5, 33, "史光临", 111, "陈浦和", "三家村" },
                    { new Guid("1110d4ca-2c55-48ca-83a1-f1b805539a01"), "川浩路22号", "320583106206", "0512-57441101", 5, null, "丁弘亮", 220, "龚炎彬", "吴加村" },
                    { new Guid("b302ebc1-70b8-4622-9d95-f0f8a499085d"), "机场路与兴陵路交叉口往南200米", "320583106205", "0512-57441476", 5, 27, "邹俊雄", 220, "程飞虎", "赵陵村" },
                    { new Guid("bd423e53-b6f6-41ce-b60c-fa641eeecf0b"), "商鞅路1号", "320583106204", "0512-50310612", 5, 20, "汤明亮", 112, "吴咏德", "七桥村" },
                    { new Guid("177e6e4b-0dd9-456c-81a5-5dbc349a521c"), "金华路1号", "320583106200", "0512-57293702", 5, 26, "宋翰学", 112, "龙昊焱", "金华村" },
                    { new Guid("707b92a8-9b42-4097-8761-0401d2707302"), "长江南路东侧与锦溪北交界", "320583106220", "0512-57256590", 5, 21, "汤英耀", 220, "蒋嘉许", "尚明甸村" },
                    { new Guid("8481e802-3f2f-4f34-9159-85c8d2c1dd45"), "振苏六村", "320583106003", "0512-55270465", 5, null, "廖景天", 111, "崔泰宁", "振苏社区" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("166e8e93-aea5-4c3c-9362-501888916e6e"), new Guid("a7429443-d8fa-49ef-8a1d-42656bd9b3d3"), new Guid("8862719c-27b4-4218-925b-63cf50421927") },
                    { new Guid("090f83d5-52a7-4c5a-b20d-3ee5bcb3e641"), new Guid("674a42bd-6c58-4744-a5d2-148da2147bd5"), new Guid("8862719c-27b4-4218-925b-63cf50421927") },
                    { new Guid("3081b6aa-aeb5-4f0d-8e7c-958d9b264e82"), new Guid("e9f15015-21ab-49e7-af9d-b0d204083c23"), new Guid("5d4f21cd-9111-4917-acfe-a6f291171a76") },
                    { new Guid("17270b80-244b-4bc6-b3c3-40ca9900222d"), new Guid("e9f15015-21ab-49e7-af9d-b0d204083c23"), new Guid("93b7b413-cde7-45bc-895e-3c05a0b95aff") },
                    { new Guid("05a5fe00-1642-41f9-b956-a21806339d0a"), new Guid("a7429443-d8fa-49ef-8a1d-42656bd9b3d3"), new Guid("72bbb09e-d9c0-4f89-a622-378a1b6937fb") }
                });
        }
    }
}
