using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCore.Entity.Migrations
{
    public partial class Migration05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AreaNumber",
                table: "Towns",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GovernmentLevel",
                table: "Towns",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Villages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    VillageName = table.Column<string>(nullable: true),
                    AreaNumber = table.Column<string>(nullable: true),
                    GovernmentLevel = table.Column<int>(nullable: false),
                    UrbanRuralClassification = table.Column<int>(nullable: false),
                    SecretaryName = table.Column<string>(nullable: true),
                    VillageHeadName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactPhone = table.Column<string>(nullable: true),
                    GroupCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { new Guid("ea8ea6c2-3056-4827-89ef-c803fcf1c8c7"), "Admin" },
                    { new Guid("73f0f099-3e60-4393-98be-1dbfe5cff93c"), "Client" },
                    { new Guid("d8f57534-95af-4e64-8e06-58fb7be4039c"), "System" }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "Address", "AreaNumber", "ChairmanName", "ContactPhone", "GovernmentLevel", "MayorName", "SecretaryName", "TownName" },
                values: new object[,]
                {
                    { new Guid("bbf0e58c-3efd-48b8-b8cb-673f9c995e07"), "普庆路1号", "320583109000", "邹鉴夕", "0521-57231290", 4, "倪御奋", "姬道生", "锦溪镇" },
                    { new Guid("08d58c85-bac9-4c8b-9ef0-e55a0487a920"), "淀南路100号", "320583107000", "陆先", "0521-57211236", 4, "王翱桦", "江衷力", "周庄镇" },
                    { new Guid("1ea4d0ab-5a19-4c8e-bb8b-b678bc399ce8"), "府前路78号", "320583105000", "常般业", "0512-57488358", 4, "冯便磊", "颜尚冲", "淀山湖镇" },
                    { new Guid("9526e380-735d-44bd-946e-270b1c14049a"), "炎东路", "320583108000", "林修胜", "0512-36620396", 4, "张弥成", "时可北", "千灯镇" },
                    { new Guid("ee8c80f3-344e-4a7a-90cc-7924917c6e81"), "新澄路918号", "320583101000", "周伟", "0521-57656330", 4, "李迪尉", "钟开桦", "巴城镇" },
                    { new Guid("04515899-7c2a-4463-bd6f-766cfbfc3362"), "菉溪路22号", "	320583103000", "李迪尉", "0512-57671003", 4, "梁灶慈", "刘群胜", "陆家镇" },
                    { new Guid("d307802b-d100-4287-b8df-6cf286267d65"), "花溪路358号", "320583104000", "武财章", "0512-57698733", 4, "王班", "吴启河", "花桥镇" },
                    { new Guid("4863580b-2b08-4b45-a7ce-3986ddd11482"), "前进东路", "320583400000", "邢栋祥", "0512-57329416", 4, "逢建德", "匡俊智", "开发区" },
                    { new Guid("e0fd0648-66bc-41d2-9f51-51d0f4c2d1f9"), "前进西路168号", "320583102000", "祖冲之", "0512-57621053", 4, "陆机", "陆云", "周市镇" },
                    { new Guid("a3a543b1-f6d5-4bd8-917a-1cf6a6325dc2"), "华杨路188号", "320583106000", "成梦昆", "0512-57452503", 4, "刘赫伯", "蒋信迟", "张浦镇" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[,]
                {
                    { new Guid("41096044-797f-41d1-91df-81a0a42d6385"), "user1", "user1" },
                    { new Guid("697373b1-b1f6-4220-9cf7-ea1baa730fd5"), "user2", "user2" },
                    { new Guid("c4a72a4e-89d1-4dcb-ab53-242a5561f70e"), "user3", "user3" },
                    { new Guid("28d7b088-d5d9-48fe-9902-1e4dfd97b5d2"), "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Villagers",
                columns: new[] { "Id", "AnnualIncome", "Birthday", "Education", "Gender", "HavingCriminalRecord", "HavingIllegalRecord", "HomeAddress", "MaritalStatus", "Name" },
                values: new object[,]
                {
                    { new Guid("af90359d-1a37-4bbb-8b23-3bb4d77567fc"), 20000, new DateTime(1984, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "高中", "男", false, false, "向阳村3组14号", "已婚", "张东" },
                    { new Guid("7dcd8f9f-faad-4303-898f-011c0f435222"), 50000, new DateTime(1990, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "本科", "男", false, false, "向阳村1组2号", "未婚", "马伦" },
                    { new Guid("91aab37e-488c-41e7-832c-e5545e00d15a"), 17000, new DateTime(1972, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "初中", "男", false, false, "向阳村5组17号", "已婚", "刘项" }
                });

            migrationBuilder.InsertData(
                table: "Villages",
                columns: new[] { "Id", "Address", "AreaNumber", "ContactPhone", "GovernmentLevel", "GroupCount", "SecretaryName", "UrbanRuralClassification", "VillageHeadName", "VillageName" },
                values: new object[,]
                {
                    { new Guid("49bb9d22-229a-4cba-aa67-b467c0b479cd"), "姚家港北首", "320583106221", "0512-57117756", 5, 22, "杨成仁", 220, "谢高义", "南姚村" },
                    { new Guid("79032c99-2d59-4051-91cb-d9c87ded786e"), "长江南路东侧与锦溪北交界", "320583106220", "0512-57256590", 5, 21, "汤英耀", 220, "蒋嘉许", "尚明甸村" },
                    { new Guid("656f28e5-ff4a-42ab-bb21-7d7bc601e9d8"), "江浦南路与C325交叉处", "320583106219", "0512-57272133", 5, 23, "漕文彦", 220, "许高岑", "姜杭村" },
                    { new Guid("bd18cf26-ca5e-4159-a8bc-ce85e62939bf"), "安头村公交站台往南60米处", "320583106215", "0512-57428927", 5, 25, "郝嘉慕", 220, "史意蕴", "安头村" },
                    { new Guid("a3310bc7-57f5-4790-8e82-bc3a51a7f244"), "南港文体站", "320583106214", "0512-57428327", 5, 28, "蒋英卓", 220, "冯兴庆", "林庄村" },
                    { new Guid("0228e783-2d9b-4640-aa81-9af3e21be276"), "建林路往北到底向西100米", "320583106212", "0512-57120550", 5, null, "万安怡", 220, "萧波峻", "白米村" },
                    { new Guid("ad766094-d31c-4434-9826-74ae713d57aa"), "陈邱家浜58号", "320583106211", "0512-50331469", 5, 44, "孙明杰", 220, "谭睿诚", "新龙村" },
                    { new Guid("dff1a174-3d99-4a04-89ea-b0d8d7a0e5e3"), "震阳路与双娄路交叉口", "320583106210", "0512-57421150", 5, 35, "贺博艺", 122, "冯鹏赋", "星金村" },
                    { new Guid("fbbfe95e-7e91-4edb-ac9e-bfd0ffae1477"), "盛巷花园门卫北侧", "320583106209", "0512-57441616", 5, 20, "韩华藏", 111, "萧泰河", "新塘村" },
                    { new Guid("73a1d12d-8061-4a36-b1f0-629580f4a553"), "港浦东路8号", "320583106207", "0512-5736863220", 5, 33, "史光临", 111, "陈浦和", "三家村" },
                    { new Guid("b20550cd-0ade-409f-b3e6-b1ae6aea2295"), "川浩路22号", "320583106206", "0512-57441101", 5, null, "丁弘亮", 220, "龚炎彬", "吴加村" },
                    { new Guid("5b70a509-ea7d-451d-8a06-fd73cb43ff5a"), "机场路与兴陵路交叉口往南200米", "320583106205", "0512-57441476", 5, 27, "邹俊雄", 220, "程飞虎", "赵陵村" },
                    { new Guid("2e5449eb-fb0c-40a4-9992-eca842875639"), "震阳路126号", "320583106004", "0512-57428835", 5, null, "阎乐池", 121, "尹和蔼", "南港社区" },
                    { new Guid("f8ddfe2e-3d58-47cf-9a3e-0c7477662a37"), "金华路1号", "320583106200", "0512-57293702", 5, 26, "宋翰学", 112, "龙昊焱", "金华村" },
                    { new Guid("7d43dc97-4997-4e71-821d-4664abb8c641"), "京东路731号", "320583106013", "0512-57278938", 5, null, "李段", 111, "吕尊", "锦和社区" },
                    { new Guid("7545fc74-b374-4a71-b5d1-971fa7ed32f8"), "京东路588号", "320583106012", "0512-57883298", 5, null, "龙澔", 111, "汤烨磊", "亲和社区" },
                    { new Guid("df947ac5-a69f-4287-99d7-6b1cc0bbcee7"), "", "320583106009", "0512-57294577", 5, 40, "姜永昌", 111, "吴凯凯", "周巷社区" },
                    { new Guid("18ccb69f-cebd-4c91-9470-d57a0daa9b0e"), "大直路504号", "320583106008", "0512-55272500", 5, 23, "梁奇希", 112, "吕勇男", "大直社区" },
                    { new Guid("49d9302e-6ed4-480c-8392-2506de8e8bf8"), "商秧路178号", "320583106007", "0512-55272500", 5, 26, "吴俊晤", 111, "石欣德", "新吴社区" },
                    { new Guid("0fc7bb9c-773a-4685-a7c3-aa3abd88a8fd"), "俱巷路894号", "320583106006", "0512-36691258", 5, null, "孔浩思", 111, "王康胜", "新巷社区" },
                    { new Guid("dd3e3e25-af91-47c0-9ccc-319b5bd2d8cf"), "淞沪西路36号", "320583106005", "0512-57256550", 5, null, "许宏畅", 220, "薛兴为", "大市社区" },
                    { new Guid("48945b51-983a-445e-9cc9-370e076ed76a"), "淞沪西路与江浦南路交叉口", "320583106226", "0512-57255236", 5, 49, "顾绍祺", 220, "金和怡", "大市村" },
                    { new Guid("688f7dd2-1c35-4149-a336-0a57c17849e0"), "振苏六村", "320583106003", "0512-55270465", 5, null, "廖景天", 111, "崔泰宁", "振苏社区" },
                    { new Guid("a5da3eb5-4846-4c61-83f8-466c7431da63"), "花苑路与京东路交叉口西侧", "320583106002", "0512-36863123", 5, 26, "汤振海", 111, "杜向阳", "花园社区" },
                    { new Guid("62e3e194-cf89-4dac-9c1a-ea5886bab2eb"), "京东路469号", "320583106001", "0512-57441175", 5, 12, "尹乐和", 111, "赵乐欣", "张浦社区" },
                    { new Guid("8b528a4b-4bd5-4044-a894-79375735e7cd"), "商鞅路1号", "320583106204", "0512-50310612", 5, 20, "汤明亮", 112, "吴咏德", "七桥村" },
                    { new Guid("79003c2c-be4c-4c53-9635-0800484f4555"), "淞沪东路12号", "320583106227", "0512-57251131", 5, null, "朱嘉石", 220, "顾飞羽", "南吉山村" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("95b400f0-10c0-43ff-b4f3-afb62895126e"), new Guid("ea8ea6c2-3056-4827-89ef-c803fcf1c8c7"), new Guid("28d7b088-d5d9-48fe-9902-1e4dfd97b5d2") },
                    { new Guid("85fa8f7a-5982-4a73-b13d-7d522f316d1a"), new Guid("d8f57534-95af-4e64-8e06-58fb7be4039c"), new Guid("28d7b088-d5d9-48fe-9902-1e4dfd97b5d2") },
                    { new Guid("8d64aef4-e53f-4756-9eda-9993e6ee70da"), new Guid("73f0f099-3e60-4393-98be-1dbfe5cff93c"), new Guid("41096044-797f-41d1-91df-81a0a42d6385") },
                    { new Guid("ec375018-5bb0-430b-be97-c6b75e1d8a19"), new Guid("73f0f099-3e60-4393-98be-1dbfe5cff93c"), new Guid("697373b1-b1f6-4220-9cf7-ea1baa730fd5") },
                    { new Guid("e0b8cfbd-1319-4796-93fc-3109d00483ef"), new Guid("ea8ea6c2-3056-4827-89ef-c803fcf1c8c7"), new Guid("c4a72a4e-89d1-4dcb-ab53-242a5561f70e") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Villages");

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("04515899-7c2a-4463-bd6f-766cfbfc3362"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("08d58c85-bac9-4c8b-9ef0-e55a0487a920"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1ea4d0ab-5a19-4c8e-bb8b-b678bc399ce8"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("4863580b-2b08-4b45-a7ce-3986ddd11482"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("9526e380-735d-44bd-946e-270b1c14049a"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("a3a543b1-f6d5-4bd8-917a-1cf6a6325dc2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("bbf0e58c-3efd-48b8-b8cb-673f9c995e07"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("d307802b-d100-4287-b8df-6cf286267d65"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("e0fd0648-66bc-41d2-9f51-51d0f4c2d1f9"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("ee8c80f3-344e-4a7a-90cc-7924917c6e81"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("85fa8f7a-5982-4a73-b13d-7d522f316d1a"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d64aef4-e53f-4756-9eda-9993e6ee70da"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("95b400f0-10c0-43ff-b4f3-afb62895126e"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("e0b8cfbd-1319-4796-93fc-3109d00483ef"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("ec375018-5bb0-430b-be97-c6b75e1d8a19"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("7dcd8f9f-faad-4303-898f-011c0f435222"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("91aab37e-488c-41e7-832c-e5545e00d15a"));

            migrationBuilder.DeleteData(
                table: "Villagers",
                keyColumn: "Id",
                keyValue: new Guid("af90359d-1a37-4bbb-8b23-3bb4d77567fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("73f0f099-3e60-4393-98be-1dbfe5cff93c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("d8f57534-95af-4e64-8e06-58fb7be4039c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ea8ea6c2-3056-4827-89ef-c803fcf1c8c7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("28d7b088-d5d9-48fe-9902-1e4dfd97b5d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("41096044-797f-41d1-91df-81a0a42d6385"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("697373b1-b1f6-4220-9cf7-ea1baa730fd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c4a72a4e-89d1-4dcb-ab53-242a5561f70e"));

            migrationBuilder.DropColumn(
                name: "AreaNumber",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "GovernmentLevel",
                table: "Towns");

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
    }
}
