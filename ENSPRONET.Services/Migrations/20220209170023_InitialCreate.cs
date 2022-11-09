using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENSPRONET.Services.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CountryName = table.Column<string>(type: "TEXT", nullable: false),
                    Alpha2Code = table.Column<string>(type: "TEXT", nullable: false),
                    Alpha3Code = table.Column<string>(type: "TEXT", nullable: false),
                    NumericCode = table.Column<int>(type: "INTEGER", nullable: false),
                    SubDivisionCode = table.Column<string>(type: "TEXT", nullable: true),
                    InternetDomain = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherForecast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TemperatureC = table.Column<int>(type: "INTEGER", nullable: false),
                    TemperatureF = table.Column<int>(type: "INTEGER", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: true),
                    CountryId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherForecast_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 1, "GU", "GUM", "Guam", ".gu", 316, "GQ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 2, "GN", "GIN", "Guinea", ".gn", 324, "GV" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 3, "LU", "LUX", "Luxembourg", ".lu", 442, "LU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 4, "SK", "SVK", "Slovakia", ".sk", 703, "LO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 5, "TF", "ATF", "French Southern Territories", ".tf", 260, "FS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 6, "BQ", "BES", "Bonaire, Saint Eustatius and Saba", ".bq", 535, "" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 7, "AQ", "ATA", "Antarctica", ".aq", 10, "AY" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 8, "ZA", "ZAF", "South Africa", ".za", 710, "SF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 9, "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 10, "MF", "MAF", "Saint Martin", ".gp", 663, "RN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 11, "LT", "LTU", "Lithuania", ".lt", 440, "LH" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 12, "IN", "IND", "India", ".in", 356, "IN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 13, "US", "USA", "United States", ".us", 840, "US" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 14, "PW", "PLW", "Palau", ".pw", 585, "PS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 15, "KP", "PRK", "North Korea", ".kp", 408, "KN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 16, "AT", "AUT", "Austria", ".at", 40, "AU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 17, "MO", "MAC", "Macao", ".mo", 446, "MC" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 18, "MU", "MUS", "Mauritius", ".mu", 480, "MP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 19, "ST", "STP", "Sao Tome and Principe", ".st", 678, "TP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 20, "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 21, "FM", "FSM", "Micronesia", ".fm", 583, "FM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 22, "HK", "HKG", "Hong Kong", ".hk", 344, "HK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 23, "IR", "IRN", "Iran", ".ir", 364, "IR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 24, "GB", "GBR", "United Kingdom", ".uk", 826, "UK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 25, "DE", "DEU", "Germany", ".de", 276, "GM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 26, "SK", "SVK", "Slovakia", ".sk", 703, "LO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 27, "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 28, "NI", "NIC", "Nicaragua", ".ni", 558, "NU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 29, "GM", "GMB", "Gambia", ".gm", 270, "GA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 30, "CR", "CRI", "Costa Rica", ".cr", 188, "CS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 31, "AU", "AUS", "Australia", ".au", 36, "AS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 32, "NL", "NLD", "Netherlands", ".nl", 528, "NL" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 33, "MZ", "MOZ", "Mozambique", ".mz", 508, "MZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 34, "GU", "GUM", "Guam", ".gu", 316, "GQ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 35, "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 36, "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 37, "KG", "KGZ", "Kyrgyzstan", ".kg", 417, "KG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 38, "MC", "MCO", "Monaco", ".mc", 492, "MN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 39, "AW", "ABW", "Aruba", ".aw", 533, "AA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 40, "CC", "CCK", "Cocos Islands", ".cc", 166, "CK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 41, "SM", "SMR", "San Marino", ".sm", 674, "SM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 42, "MV", "MDV", "Maldives", ".mv", 462, "MV" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 43, "HN", "HND", "Honduras", ".hn", 340, "HO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 44, "BS", "BHS", "Bahamas", ".bs", 44, "BF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 45, "GB", "GBR", "United Kingdom", ".uk", 826, "UK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 46, "CU", "CUB", "Cuba", ".cu", 192, "CU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 47, "FM", "FSM", "Micronesia", ".fm", 583, "FM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 48, "CX", "CXR", "Christmas Island", ".cx", 162, "KT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 49, "LU", "LUX", "Luxembourg", ".lu", 442, "LU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 50, "DJ", "DJI", "Djibouti", ".dj", 262, "DJ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 51, "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 52, "PT", "PRT", "Portugal", ".pt", 620, "PO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 53, "TG", "TGO", "Togo", ".tg", 768, "TO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 54, "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 55, "PE", "PER", "Peru", ".pe", 604, "PE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 56, "LS", "LSO", "Lesotho", ".ls", 426, "LT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 57, "RS", "SRB", "Serbia", ".rs", 688, "RI" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 58, "AX", "ALA", "Aland Islands", ".ax", 248, "" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 59, "CF", "CAF", "Central African Republic", ".cf", 140, "CT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 60, "ZM", "ZMB", "Zambia", ".zm", 894, "ZA" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 61, "FK", "FLK", "Falkland Islands", ".fk", 238, "FK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 62, "DM", "DMA", "Dominica", ".dm", 212, "DO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 63, "FR", "FRA", "France", ".fr", 250, "FR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 64, "BG", "BGR", "Bulgaria", ".bg", 100, "BU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 65, "AR", "ARG", "Argentina", ".ar", 32, "AR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 66, "PS", "PSE", "Palestinian Territory", ".ps", 275, "WE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 67, "SR", "SUR", "Suriname", ".sr", 740, "NS" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 68, "LK", "LKA", "Sri Lanka", ".lk", 144, "CE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 69, "VG", "VGB", "British Virgin Islands", ".vg", 92, "VI" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 70, "BB", "BRB", "Barbados", ".bb", 52, "BB" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 71, "AD", "AND", "Andorra", ".ad", 20, "AN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 72, "NE", "NER", "Niger", ".ne", 562, "NG" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 73, "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 74, "BJ", "BEN", "Benin", ".bj", 204, "BN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 75, "PG", "PNG", "Papua New Guinea", ".pg", 598, "PP" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 76, "SS", "SSD", "South Sudan", ".ss", 728, "OD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 77, "JM", "JAM", "Jamaica", ".jm", 388, "JM" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 78, "ID", "IDN", "Indonesia", ".id", 360, "ID" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 79, "AO", "AGO", "Angola", ".ao", 24, "AO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 80, "UZ", "UZB", "Uzbekistan", ".uz", 860, "UZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 81, "DM", "DMA", "Dominica", ".dm", 212, "DO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 82, "AE", "ARE", "United Arab Emirates", ".ae", 784, "AE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 83, "BM", "BMU", "Bermuda", ".bm", 60, "BD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 84, "ZA", "ZAF", "South Africa", ".za", 710, "SF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 85, "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 86, "LS", "LSO", "Lesotho", ".ls", 426, "LT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 87, "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 88, "CZ", "CZE", "Czechia", ".cz", 203, "EZ" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 89, "PE", "PER", "Peru", ".pe", 604, "PE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 90, "CL", "CHL", "Chile", ".cl", 152, "CI" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 91, "NO", "NOR", "Norway", ".no", 578, "NO" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 92, "TL", "TLS", "Timor Leste", ".tl", 626, "TT" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 93, "NF", "NFK", "Norfolk Island", ".nf", 574, "NF" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 94, "SD", "SDN", "Sudan", ".sd", 729, "SU" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 95, "TT", "TTO", "Trinidad and Tobago", ".tt", 780, "TD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 96, "FI", "FIN", "Finland", ".fi", 246, "FI" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 97, "GQ", "GNQ", "Equatorial Guinea", ".gq", 226, "EK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 98, "SS", "SSD", "South Sudan", ".ss", 728, "OD" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 99, "GG", "GGY", "Guernsey", ".gg", 831, "GK" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { 100, "HM", "HMD", "Heard Island and McDonald Islands", ".hm", 334, "HM" });

            migrationBuilder.CreateIndex(
                name: "IX_WeatherForecast_CountryId",
                table: "WeatherForecast",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecast");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
