using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "HighLevelAreaNumber",
                table: "Villages",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "HighLevelAreaNumber",
                table: "Villages");

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
    }
}
