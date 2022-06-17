using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class GenusOfDogAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a150cd66-dfdc-48f3-a2b9-1da430e7b9e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2b6ca36-6fcf-4e60-85ed-7435339baf2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf3da6c-cb2f-4c4b-b554-6b5a4b8451bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2e9ca94-5270-456d-b931-d4627f24dfb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dce5216f-d3a9-4f57-a0d9-a515a6618de6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a02c3e-a694-4032-a972-78e45713acc7");

            migrationBuilder.AddColumn<bool>(
                name: "GenusType",
                table: "Genus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31033917-ce26-4472-aa0b-22ad692ab1e8", "4cda01b0-4fd9-479e-bb00-258823f1c643", "UserRole", "HighUser", null },
                    { "3c7cdba9-7d0a-4650-87cb-2900529df2bf", "54cc9ae3-94fa-4f64-9047-6466208961de", "UserRole", "Admin", null },
                    { "546712bf-5df4-474a-a357-9e4b997d5353", "1fb95816-ba35-4a95-81ea-c5c19c23e647", "UserRole", "Editor", null },
                    { "7ec2495d-cae6-4161-bc2b-4513a9a03c6b", "0d028cf4-438d-4c8d-b2ca-9054e41ca4d8", "UserRole", "MidUser", null },
                    { "a1962c61-8529-494e-97fc-a84deb378129", "32c5ae16-f903-4529-984b-67f60926edd3", "UserRole", "Creator", null },
                    { "f3d7b59b-0761-4f13-bd69-46fc5d88682f", "97ae8ad6-1085-470f-8929-6848031ab029", "UserRole", "BasicUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2182), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2195), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2197), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2198), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2200), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2201), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2203), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2204), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2205), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2206), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2208), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2209), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2210), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2213), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2215), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2216), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2217), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2218), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2220), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2221), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2222), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2225), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2226), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2227), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2229), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2230), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2231), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2233), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2234), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2235), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2236), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2238), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2239), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2240), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2242), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2243), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2244), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2245), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2247), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.InsertData(
                table: "Genus",
                columns: new[] { "Id", "CreateTime", "GenusName", "GenusType", "UpdateTime" },
                values: new object[,]
                {
                    { 40, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2248), "Buldog", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2248) },
                    { 41, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2249), "Labrador retriever", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2250) },
                    { 42, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2250), "Alman çoban köpeği", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2251) },
                    { 43, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2252), "Kaniş", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2252) },
                    { 44, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2253), "Golden Retriever", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2254) },
                    { 45, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2254), "Chihuahua", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2255) },
                    { 46, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2255), "Fransız buldoğu", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2256) },
                    { 47, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2257), "Bişon çuha köpeği", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2257) },
                    { 48, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2258), "Boksör", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2259) },
                    { 49, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2259), "Border collie", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2260) },
                    { 50, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2261), "Sibirya kurdu", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2261) },
                    { 51, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2262), "Pug", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2262) },
                    { 52, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2263), "Amerikan Staffordshire teriyeri", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2264) },
                    { 53, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2264), "Boston Terrier", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2265) },
                    { 54, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2266), "Cavalier King Charles Spaniel", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2266) },
                    { 55, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2267), "Pomeranian", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2267) },
                    { 56, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2268), "Yorkshire teriyeri", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2269) },
                    { 57, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2269), "Bull teriyer", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2270) },
                    { 58, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2271), "İngiliz Cocker Spaniel", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2271) },
                    { 59, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2272), "Amerikan Eskimo Köpeği", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2272) },
                    { 60, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2273), "Danua", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2274) },
                    { 61, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2274), "Malta köpeği", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2275) },
                    { 62, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2276), "Çov-çov", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2276) },
                    { 63, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2277), "Affenpinscher", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2277) },
                    { 64, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2278), "Basenji", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2278) },
                    { 65, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2279), "Dakhund", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2280) },
                    { 66, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2281), "Bretonya epanyölü", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2281) },
                    { 67, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2282), "Bulmastif", true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2283) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31033917-ce26-4472-aa0b-22ad692ab1e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c7cdba9-7d0a-4650-87cb-2900529df2bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546712bf-5df4-474a-a357-9e4b997d5353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ec2495d-cae6-4161-bc2b-4513a9a03c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1962c61-8529-494e-97fc-a84deb378129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d7b59b-0761-4f13-bd69-46fc5d88682f");

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DropColumn(
                name: "GenusType",
                table: "Genus");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a150cd66-dfdc-48f3-a2b9-1da430e7b9e6", "fb80c04c-2593-469a-b1ce-8bbf27e89c6f", "UserRole", "MidUser", null },
                    { "c2b6ca36-6fcf-4e60-85ed-7435339baf2e", "37b73f51-e5f2-4b3d-ac4e-ad3f989ccc38", "UserRole", "Admin", null },
                    { "ccf3da6c-cb2f-4c4b-b554-6b5a4b8451bb", "fb820977-6dd7-45bd-bae0-c75058f9dbd5", "UserRole", "Editor", null },
                    { "d2e9ca94-5270-456d-b931-d4627f24dfb3", "8f05c7a3-4264-4569-bc96-bfed40ea0642", "UserRole", "BasicUser", null },
                    { "dce5216f-d3a9-4f57-a0d9-a515a6618de6", "b82beaf8-a626-49ce-85b7-bebcb1b5857b", "UserRole", "HighUser", null },
                    { "e3a02c3e-a694-4032-a972-78e45713acc7", "70fe3092-e087-4e0b-b8f5-243294c520d5", "UserRole", "Creator", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9837), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9849) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9850), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9851), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9853), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9854), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9855), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9856), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9857), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9859), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9862), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9863), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9864), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9865), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9866), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9867), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9868), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9869), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9871), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9872), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9873), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9874), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9876), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9877), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9878), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9879), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9881), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9882), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9884), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9885) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9886), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9887), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9888), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9889), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9892), new DateTime(2022, 6, 17, 21, 43, 21, 950, DateTimeKind.Local).AddTicks(9892) });
        }
    }
}
