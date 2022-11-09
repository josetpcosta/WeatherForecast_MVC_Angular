using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ENSPRONET.Services.Migrations
{
    public partial class addednavigationpropweatherforecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherForecast_Countries_CountryId",
                table: "WeatherForecast");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "WeatherForecast",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GF", "GUF", "French Guiana", ".gf", 254, "FG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TG", "TGO", "Togo", ".tg", 768, "TO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "OM", "OMN", "Oman", ".om", 512, "MU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SO", "SOM", "Somalia", ".so", 706, "SO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NL", "NLD", "Netherlands", ".nl", 528, "NL" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KM", "COM", "Comoros", ".km", 174, "CN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KR", "KOR", "South Korea", ".kr", 410, "KS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BJ", "BEN", "Benin", ".bj", 204, "BN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FR", "FRA", "France", ".fr", 250, "FR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PA", "PAN", "Panama", ".pa", 591, "PM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BW", "BWA", "Botswana", ".bw", 72, "BC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MP", "MNP", "Northern Mariana Islands", ".mp", 580, "CQ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KP", "PRK", "North Korea", ".kp", 408, "KN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FJ", "FJI", "Fiji", ".fj", 242, "FJ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FR", "FRA", "France", ".fr", 250, "FR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NE", "NER", "Niger", ".ne", 562, "NG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BE", "BEL", "Belgium", ".be", 56, "BE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CX", "CXR", "Christmas Island", ".cx", 162, "KT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BD", "BGD", "Bangladesh", ".bd", 50, "BG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BZ", "BLZ", "Belize", ".bz", 84, "BH" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CU", "CUB", "Cuba", ".cu", 192, "CU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AQ", "ATA", "Antarctica", ".aq", 10, "AY" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KP", "PRK", "North Korea", ".kp", 408, "KN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZW", "ZWE", "Zimbabwe", ".zw", 716, "ZI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DZ", "DZA", "Algeria", ".dz", 12, "AG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PK", "PAK", "Pakistan", ".pk", 586, "PK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DJ", "DJI", "Djibouti", ".dj", 262, "DJ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BB", "BRB", "Barbados", ".bb", 52, "BB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AS", "ASM", "American Samoa", ".as", 16, "AQ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MG", "MDG", "Madagascar", ".mg", 450, "MA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VA", "VAT", "Vatican", ".va", 336, "VT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AM", "ARM", "Armenia", ".am", 51, "AM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FR", "FRA", "France", ".fr", 250, "FR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CG", "COG", "Republic of the Congo", ".cg", 178, "CF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "IE", "IRL", "Ireland", ".ie", 372, "EI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AT", "AUT", "Austria", ".at", 40, "AU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BL", "BLM", "Saint Barthelemy", ".gp", 652, "TB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LR", "LBR", "Liberia", ".lr", 430, "LI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DK", "DNK", "Denmark", ".dk", 208, "DA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "RU", "RUS", "Russia", ".ru", 643, "RS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BJ", "BEN", "Benin", ".bj", 204, "BN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MH", "MHL", "Marshall Islands", ".mh", 584, "RM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NC", "NCL", "New Caledonia", ".nc", 540, "NC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MD", "MDA", "Moldova", ".md", 498, "MD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AF", "AFG", "Afghanistan", ".af", 4, "AF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PH", "PHL", "Philippines", ".ph", 608, "RP" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MX", "MEX", "Mexico", ".mx", 484, "MX" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MO", "MAC", "Macao", ".mo", 446, "MC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PN", "PCN", "Pitcairn", ".pn", 612, "PC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZA", "ZAF", "South Africa", ".za", 710, "SF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AL", "ALB", "Albania", ".al", 8, "AL" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "YT", "MYT", "Mayotte", ".yt", 175, "MF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CH", "CHE", "Switzerland", ".ch", 756, "SZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "RS", "SRB", "Serbia", ".rs", 688, "RI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "UZ", "UZB", "Uzbekistan", ".uz", 860, "UZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GY", "GUY", "Guyana", ".gy", 328, "GY" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BM", "BMU", "Bermuda", ".bm", 60, "BD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CC", "CCK", "Cocos Islands", ".cc", 166, "CK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LB", "LBN", "Lebanon", ".lb", 422, "LE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CR", "CRI", "Costa Rica", ".cr", 188, "CS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CX", "CXR", "Christmas Island", ".cx", 162, "KT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AR", "ARG", "Argentina", ".ar", 32, "AR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LU", "LUX", "Luxembourg", ".lu", 442, "LU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KY", "CYM", "Cayman Islands", ".ky", 136, "CJ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "HM", "HMD", "Heard Island and McDonald Islands", ".hm", 334, "HM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DO", "DOM", "Dominican Republic", ".do", 214, "DR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GL", "GRL", "Greenland", ".gl", 304, "GL" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NZ", "NZL", "New Zealand", ".nz", 554, "NZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TR", "TUR", "Turkey", ".tr", 792, "TU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CD", "COD", "Democratic Republic of the Congo", ".cd", 180, "CG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZM", "ZMB", "Zambia", ".zm", 894, "ZA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LT", "LTU", "Lithuania", ".lt", 440, "LH" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CU", "CUB", "Cuba", ".cu", 192, "CU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LA", "LAO", "Laos", ".la", 418, "LA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "IS", "ISL", "Iceland", ".is", 352, "IC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AI", "AIA", "Anguilla", ".ai", 660, "AV" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BE", "BEL", "Belgium", ".be", 56, "BE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TD", "TCD", "Chad", ".td", 148, "CD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AN", "ANT", "Netherlands Antilles", ".an", 530, "NT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LY", "LBY", "Libya", ".ly", 434, "LY" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MS", "MSR", "Montserrat", ".ms", 500, "MH" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AM", "ARM", "Armenia", ".am", 51, "AM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TF", "ATF", "French Southern Territories", ".tf", 260, "FS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LA", "LAO", "Laos", ".la", 418, "LA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KN", "KNA", "Saint Kitts and Nevis", ".kn", 659, "SC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AT", "AUT", "Austria", ".at", 40, "AU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NR", "NRU", "Nauru", ".nr", 520, "NR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VN", "VNM", "Vietnam", ".vn", 704, "VM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MO", "MAC", "Macao", ".mo", 446, "MC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BD", "BGD", "Bangladesh", ".bd", 50, "BG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VA", "VAT", "Vatican", ".va", 336, "VT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AU", "AUS", "Australia", ".au", 36, "AS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "OM", "OMN", "Oman", ".om", 512, "MU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CU", "CUB", "Cuba", ".cu", 192, "CU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CX", "CXR", "Christmas Island", ".cx", 162, "KT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SO", "SOM", "Somalia", ".so", 706, "SO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TJ", "TJK", "Tajikistan", ".tj", 762, "TI" });

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherForecast_Countries_CountryId",
                table: "WeatherForecast",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeatherForecast_Countries_CountryId",
                table: "WeatherForecast");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "WeatherForecast",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GU", "GUM", "Guam", ".gu", 316, "GQ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GN", "GIN", "Guinea", ".gn", 324, "GV" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LU", "LUX", "Luxembourg", ".lu", 442, "LU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SK", "SVK", "Slovakia", ".sk", 703, "LO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TF", "ATF", "French Southern Territories", ".tf", 260, "FS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BQ", "BES", "Bonaire, Saint Eustatius and Saba", ".bq", 535, "" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AQ", "ATA", "Antarctica", ".aq", 10, "AY" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZA", "ZAF", "South Africa", ".za", 710, "SF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MF", "MAF", "Saint Martin", ".gp", 663, "RN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LT", "LTU", "Lithuania", ".lt", 440, "LH" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "IN", "IND", "India", ".in", 356, "IN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "US", "USA", "United States", ".us", 840, "US" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PW", "PLW", "Palau", ".pw", 585, "PS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KP", "PRK", "North Korea", ".kp", 408, "KN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AT", "AUT", "Austria", ".at", 40, "AU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MO", "MAC", "Macao", ".mo", 446, "MC" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MU", "MUS", "Mauritius", ".mu", 480, "MP" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ST", "STP", "Sao Tome and Principe", ".st", 678, "TP" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FM", "FSM", "Micronesia", ".fm", 583, "FM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "HK", "HKG", "Hong Kong", ".hk", 344, "HK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "IR", "IRN", "Iran", ".ir", 364, "IR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GB", "GBR", "United Kingdom", ".uk", 826, "UK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DE", "DEU", "Germany", ".de", 276, "GM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SK", "SVK", "Slovakia", ".sk", 703, "LO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NI", "NIC", "Nicaragua", ".ni", 558, "NU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GM", "GMB", "Gambia", ".gm", 270, "GA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CR", "CRI", "Costa Rica", ".cr", 188, "CS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AU", "AUS", "Australia", ".au", 36, "AS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NL", "NLD", "Netherlands", ".nl", 528, "NL" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MZ", "MOZ", "Mozambique", ".mz", 508, "MZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GU", "GUM", "Guam", ".gu", 316, "GQ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "KG", "KGZ", "Kyrgyzstan", ".kg", 417, "KG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MC", "MCO", "Monaco", ".mc", 492, "MN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AW", "ABW", "Aruba", ".aw", 533, "AA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CC", "CCK", "Cocos Islands", ".cc", 166, "CK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SM", "SMR", "San Marino", ".sm", 674, "SM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "MV", "MDV", "Maldives", ".mv", 462, "MV" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "HN", "HND", "Honduras", ".hn", 340, "HO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BS", "BHS", "Bahamas", ".bs", 44, "BF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GB", "GBR", "United Kingdom", ".uk", 826, "UK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CU", "CUB", "Cuba", ".cu", 192, "CU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FM", "FSM", "Micronesia", ".fm", 583, "FM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CX", "CXR", "Christmas Island", ".cx", 162, "KT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LU", "LUX", "Luxembourg", ".lu", 442, "LU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DJ", "DJI", "Djibouti", ".dj", 262, "DJ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GA", "GAB", "Gabon", ".ga", 266, "GB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PT", "PRT", "Portugal", ".pt", 620, "PO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TG", "TGO", "Togo", ".tg", 768, "TO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SE", "SWE", "Sweden", ".se", 752, "SW" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PE", "PER", "Peru", ".pe", 604, "PE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LS", "LSO", "Lesotho", ".ls", 426, "LT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "RS", "SRB", "Serbia", ".rs", 688, "RI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AX", "ALA", "Aland Islands", ".ax", 248, "" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CF", "CAF", "Central African Republic", ".cf", 140, "CT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZM", "ZMB", "Zambia", ".zm", 894, "ZA" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FK", "FLK", "Falkland Islands", ".fk", 238, "FK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DM", "DMA", "Dominica", ".dm", 212, "DO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FR", "FRA", "France", ".fr", 250, "FR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BG", "BGR", "Bulgaria", ".bg", 100, "BU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AR", "ARG", "Argentina", ".ar", 32, "AR" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PS", "PSE", "Palestinian Territory", ".ps", 275, "WE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SR", "SUR", "Suriname", ".sr", 740, "NS" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LK", "LKA", "Sri Lanka", ".lk", 144, "CE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VG", "VGB", "British Virgin Islands", ".vg", 92, "VI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BB", "BRB", "Barbados", ".bb", 52, "BB" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AD", "AND", "Andorra", ".ad", 20, "AN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NE", "NER", "Niger", ".ne", 562, "NG" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BJ", "BEN", "Benin", ".bj", 204, "BN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PG", "PNG", "Papua New Guinea", ".pg", 598, "PP" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SS", "SSD", "South Sudan", ".ss", 728, "OD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "JM", "JAM", "Jamaica", ".jm", 388, "JM" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ID", "IDN", "Indonesia", ".id", 360, "ID" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AO", "AGO", "Angola", ".ao", 24, "AO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "UZ", "UZB", "Uzbekistan", ".uz", 860, "UZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "DM", "DMA", "Dominica", ".dm", 212, "DO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "AE", "ARE", "United Arab Emirates", ".ae", 784, "AE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "BM", "BMU", "Bermuda", ".bm", 60, "BD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "ZA", "ZAF", "South Africa", ".za", 710, "SF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SG", "SGP", "Singapore", ".sg", 702, "SN" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "LS", "LSO", "Lesotho", ".ls", 426, "LT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "VE", "VEN", "Venezuela", ".ve", 862, "VE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CZ", "CZE", "Czechia", ".cz", 203, "EZ" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "PE", "PER", "Peru", ".pe", 604, "PE" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "CL", "CHL", "Chile", ".cl", 152, "CI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NO", "NOR", "Norway", ".no", 578, "NO" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TL", "TLS", "Timor Leste", ".tl", 626, "TT" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "NF", "NFK", "Norfolk Island", ".nf", 574, "NF" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SD", "SDN", "Sudan", ".sd", 729, "SU" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "TT", "TTO", "Trinidad and Tobago", ".tt", 780, "TD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "FI", "FIN", "Finland", ".fi", 246, "FI" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GQ", "GNQ", "Equatorial Guinea", ".gq", 226, "EK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "SS", "SSD", "South Sudan", ".ss", 728, "OD" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "GG", "GGY", "Guernsey", ".gg", 831, "GK" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Alpha2Code", "Alpha3Code", "CountryName", "InternetDomain", "NumericCode", "SubDivisionCode" },
                values: new object[] { "HM", "HMD", "Heard Island and McDonald Islands", ".hm", 334, "HM" });

            migrationBuilder.AddForeignKey(
                name: "FK_WeatherForecast_Countries_CountryId",
                table: "WeatherForecast",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");
        }
    }
}
