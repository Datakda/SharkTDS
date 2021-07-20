using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SharkTDS.Migrations
{
    public partial class AddStat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identifier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeRedirect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrlORCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReplaceToCURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeoBase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniquenessCheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermUniqueness = table.Column<int>(type: "int", nullable: false),
                    IsActiveBanGroupToTime = table.Column<bool>(type: "bit", nullable: false),
                    LimitQestion = table.Column<int>(type: "int", nullable: false),
                    TimePeriod = table.Column<int>(type: "int", nullable: false),
                    SaveKeys = table.Column<bool>(type: "bit", nullable: false),
                    SaveKeysOfReferer = table.Column<bool>(type: "bit", nullable: false),
                    GroupIsActive = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxMindKey = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Identifier = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeRedirect = table.Column<int>(type: "int", nullable: false),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeDistribution = table.Column<int>(type: "int", nullable: false),
                    UrlOrCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurlReplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveFlow = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Сomputer = table.Column<byte>(type: "tinyint", nullable: false),
                    Mobile = table.Column<byte>(type: "tinyint", nullable: false),
                    Tablet = table.Column<byte>(type: "tinyint", nullable: false),
                    Beeline = table.Column<byte>(type: "tinyint", nullable: false),
                    Megafon = table.Column<byte>(type: "tinyint", nullable: false),
                    Mts = table.Column<byte>(type: "tinyint", nullable: false),
                    Tele2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Azerbaijan = table.Column<byte>(type: "tinyint", nullable: false),
                    Belarus = table.Column<byte>(type: "tinyint", nullable: false),
                    Kazakhstan = table.Column<byte>(type: "tinyint", nullable: false),
                    Ukraine = table.Column<byte>(type: "tinyint", nullable: false),
                    Wap_1 = table.Column<byte>(type: "tinyint", nullable: false),
                    Wap_2 = table.Column<byte>(type: "tinyint", nullable: false),
                    Wap_3 = table.Column<byte>(type: "tinyint", nullable: false),
                    IsActiveCountry = table.Column<byte>(type: "tinyint", nullable: false),
                    Countries = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveCity = table.Column<byte>(type: "tinyint", nullable: false),
                    Cities = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveRegion = table.Column<byte>(type: "tinyint", nullable: false),
                    Regions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrowserLanguag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveBrowserLanguage = table.Column<byte>(type: "tinyint", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveAvailabilityInUserAgent = table.Column<byte>(type: "tinyint", nullable: false),
                    Referer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveAvailabilityInReferer = table.Column<byte>(type: "tinyint", nullable: false),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveDomainName = table.Column<byte>(type: "tinyint", nullable: false),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveAvailabilityInKeyword = table.Column<byte>(type: "tinyint", nullable: false),
                    NonUniqueVisitors = table.Column<byte>(type: "tinyint", nullable: false),
                    BlankReferer = table.Column<byte>(type: "tinyint", nullable: false),
                    ActionOnBots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderBots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BotsUrlOrCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BotsReplaceToCURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActiveSignsBotUserAgent = table.Column<bool>(type: "bit", nullable: false),
                    EmptyUserAgent = table.Column<bool>(type: "bit", nullable: false),
                    EmptyReferer = table.Column<bool>(type: "bit", nullable: false),
                    EmptyBrowserLanguage = table.Column<bool>(type: "bit", nullable: false),
                    IPV6 = table.Column<bool>(type: "bit", nullable: false),
                    BlackListUserAgent = table.Column<bool>(type: "bit", nullable: false),
                    Baidu = table.Column<bool>(type: "bit", nullable: false),
                    Bing = table.Column<bool>(type: "bit", nullable: false),
                    Google = table.Column<bool>(type: "bit", nullable: false),
                    Mailru = table.Column<bool>(type: "bit", nullable: false),
                    Yahoo = table.Column<bool>(type: "bit", nullable: false),
                    Yandex = table.Column<bool>(type: "bit", nullable: false),
                    Others = table.Column<bool>(type: "bit", nullable: false),
                    SaveIpBot = table.Column<bool>(type: "bit", nullable: false),
                    IsActiveLimit = table.Column<bool>(type: "bit", nullable: false),
                    Visitors = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flows_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlowID = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Out = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Redirect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Device = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wap = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uniq = table.Column<bool>(type: "bit", nullable: false),
                    Bot = table.Column<bool>(type: "bit", nullable: false),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Flows_FlowID",
                        column: x => x.FlowID,
                        principalTable: "Flows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flows_GroupId",
                table: "Flows",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Stats_FlowID",
                table: "Stats",
                column: "FlowID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Flows");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
