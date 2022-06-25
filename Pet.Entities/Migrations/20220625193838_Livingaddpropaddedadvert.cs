using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Livingaddpropaddedadvert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "161b57c7-e73e-4609-b3fc-739293d6a610");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b8dee41-2c31-4b4d-8a1c-c05b0db43eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43207243-d118-4786-a835-382ab781d0d0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cecf585-debc-4b83-8683-4ec21b565620");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f1965d2-8554-4526-8d1b-fc9909a6075f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2fb74ad-af25-4b4f-8fe8-3f7248b1795e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "493c9b44-a9cc-49c4-8e22-dc7e25575bc4", "fe544a13-930f-414c-8829-32c734cba419", "UserRole", "HighUser", null },
                    { "4db7c735-8208-4a4e-8df0-c234f6667c5b", "fb38f5f1-88b8-479b-8207-7353d318bd78", "UserRole", "Editor", null },
                    { "504900a4-ceeb-4ffc-85ad-248744ba87f4", "202c5d67-82dc-4e2e-b832-0f06936f65a4", "UserRole", "BasicUser", null },
                    { "75b65ff7-aea6-4119-9510-da76fad95587", "b3499e4b-1315-4653-9d65-dab0f67cd41f", "UserRole", "Creator", null },
                    { "d5c7020c-e9e3-4dc5-8ecc-0630c4eb1531", "b9a9fe3b-402d-49eb-9b8d-2d08a0860db5", "UserRole", "MidUser", null },
                    { "d79ef067-01a6-475e-bf44-8549fd45b507", "b5d0c7a2-928a-40ff-ae27-8e0bfaa96b12", "UserRole", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1981), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1995), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1998), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2002), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2004), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2006), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2009), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2010), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2014), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2016), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2017), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2021), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2022), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2023), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2024), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2025) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2025), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2026), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2028), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2031), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2032), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2033), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2035), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2036), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2038), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2039), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2043), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2044), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2045), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2047), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2048), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2049), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2051), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2052), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2087), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2088), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2091), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2092), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2093), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2095), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2096), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2097), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2098), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2099), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2101), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2102), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2103), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2105), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2106), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2109), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2536), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2538), new DateTime(2022, 6, 25, 22, 38, 38, 277, DateTimeKind.Local).AddTicks(2538) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "493c9b44-a9cc-49c4-8e22-dc7e25575bc4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4db7c735-8208-4a4e-8df0-c234f6667c5b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "504900a4-ceeb-4ffc-85ad-248744ba87f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75b65ff7-aea6-4119-9510-da76fad95587");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5c7020c-e9e3-4dc5-8ecc-0630c4eb1531");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d79ef067-01a6-475e-bf44-8549fd45b507");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "161b57c7-e73e-4609-b3fc-739293d6a610", "6fd1248f-6781-4cf8-9d38-eeafc87303f6", "UserRole", "MidUser", null },
                    { "3b8dee41-2c31-4b4d-8a1c-c05b0db43eff", "f777212c-126a-4f51-adf9-c4ff69784b0f", "UserRole", "HighUser", null },
                    { "43207243-d118-4786-a835-382ab781d0d0", "29fe5b12-2bf0-42cd-9ba8-49699f7568c0", "UserRole", "Editor", null },
                    { "6cecf585-debc-4b83-8683-4ec21b565620", "718b5fa2-4b92-499d-ad80-856e477581d1", "UserRole", "Admin", null },
                    { "8f1965d2-8554-4526-8d1b-fc9909a6075f", "bc253cda-eb57-4165-9374-e2d572791328", "UserRole", "Creator", null },
                    { "f2fb74ad-af25-4b4f-8fe8-3f7248b1795e", "87a69d0d-fd34-4761-b868-9171456be7f0", "UserRole", "BasicUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4616), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4628), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4629), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4631), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4632), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4634), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4635), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4636), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4637), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4638), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4640), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4641), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4642), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4643), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4646), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4648), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4649), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4651), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4653), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4655), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4657), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4658), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4659), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4661), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4662), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4663), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4664), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4665), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4668), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4669), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4670), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4671), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4673), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4674), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4675), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4677), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4678), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4679), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4681), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4682), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4684), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4685), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4686), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4687), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4690), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4691), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4692), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4693), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4694), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4695), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4697), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4697) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4698), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4699), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4699) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4701), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4703), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4704), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4705), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4705) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4706), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4707) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4707), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4708), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4923), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4925), new DateTime(2022, 6, 24, 22, 32, 10, 83, DateTimeKind.Local).AddTicks(4925) });
        }
    }
}
