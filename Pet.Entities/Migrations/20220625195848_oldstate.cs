using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class oldstate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1ba68496-b4a9-438f-839d-4bdeb3b82b2b", "b6c7ae37-ec1a-4b45-b593-723a3bca0bbe", "UserRole", "HighUser", null },
                    { "2b9da517-5fd0-4428-9d16-f2b173ee932f", "786e19f0-7fad-4d0e-b357-a37f4bc34fbd", "UserRole", "Editor", null },
                    { "4479cf9b-7a24-4400-84ab-150d6c3db8d9", "1d25afec-3533-439d-9fc4-0f17e04df331", "UserRole", "MidUser", null },
                    { "61d97b38-2baa-4c27-9638-14fa9006022d", "8873bcfa-170c-4897-8add-9c425ee21e32", "UserRole", "Admin", null },
                    { "c40318e9-a524-479d-b599-8d54aa0eace6", "9f146792-be55-4ed1-8ad2-64bb6bea0818", "UserRole", "Creator", null },
                    { "e7610f19-d477-433f-9d17-3f751130f3ee", "5a29a9ab-373e-4e08-9f82-e18559428b2c", "UserRole", "BasicUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(257), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(269), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(271), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(272), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(274), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(276), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(277), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(282), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(283), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(284), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(285), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(287), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(287) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(288), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(289), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(291), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(292), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(292) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(294), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(296), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(297), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(298), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(302), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(305), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(311), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(322), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(325), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(327), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(332), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(333), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(335), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(336), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(341), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(342), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(343) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(343), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(344), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(346), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(346) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(347), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(348), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(349), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(452), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(453) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(454), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(455), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(458), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(459), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(460) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(461) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(461), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(463), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(464), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(465), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(466), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(467), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(744), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(746), new DateTime(2022, 6, 25, 22, 58, 47, 743, DateTimeKind.Local).AddTicks(747) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ba68496-b4a9-438f-839d-4bdeb3b82b2b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b9da517-5fd0-4428-9d16-f2b173ee932f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4479cf9b-7a24-4400-84ab-150d6c3db8d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61d97b38-2baa-4c27-9638-14fa9006022d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c40318e9-a524-479d-b599-8d54aa0eace6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7610f19-d477-433f-9d17-3f751130f3ee");

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
    }
}
