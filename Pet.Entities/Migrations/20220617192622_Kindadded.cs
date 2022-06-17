using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Kindadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df64233-d6d6-45a0-b0ab-d8f3952220c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35bef7d9-923a-4366-8fdc-a75a342120c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "588d8eea-367a-418d-a3c0-721005f6dc7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "790d7d6f-6d8c-4efc-9d79-5b6e2a888bec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99979c78-09f3-4fca-9e45-fd934f30304d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a035142-3b10-45b0-8c9d-45c72123a407");

            migrationBuilder.DropColumn(
                name: "KindFamilya",
                table: "Kinds");

            migrationBuilder.DropColumn(
                name: "KindTeam",
                table: "Kinds");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03f597c7-b511-4266-a10f-591bc27e4875", "b473d760-70ff-46c0-aa18-b3f0ebf9ecb3", "UserRole", "MidUser", null },
                    { "81509776-31bb-49c9-ab2b-27b855bc8f0d", "7c16aa57-4829-4ada-9e69-64823c01a9aa", "UserRole", "Editor", null },
                    { "a9fc3e73-76c8-4f7d-b113-7a852719f669", "7d7c2d24-2e09-4499-ad4e-880b3cb99f7c", "UserRole", "BasicUser", null },
                    { "ae6f0671-3321-41d3-8297-56b980eb1e3a", "20a42d19-2bed-4983-841c-49f8c8be8134", "UserRole", "Creator", null },
                    { "e5c740be-527f-4cd1-ae16-7944dffd0a43", "2786024b-f122-4829-bfca-50648e4a7a88", "UserRole", "HighUser", null },
                    { "e7965cd5-c2da-4297-a417-1851c262184b", "7d2fc316-7a42-4f48-acd7-538962f22e62", "UserRole", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1202), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1215), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1217) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1220), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1223), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1225), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1226), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1227), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1232), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1233), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1237), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1242), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1243), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1244), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1245), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1247), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1248), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1249), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1250), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1253), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1255), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1256), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1258), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1259), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1261), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1262), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1263), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1304), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1308), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1309), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1310), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1311), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1313), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1313) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1314), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1316), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1319), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1322) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1322), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1324) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1325), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1329) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1330), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1331), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1331) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1332), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1334) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1335), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1336), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1337), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1339), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.InsertData(
                table: "Kinds",
                columns: new[] { "Id", "CreateTime", "Familya", "Team", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1666), 0, 0, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1666) },
                    { 2, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1668), 1, 2, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1669) },
                    { 3, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1670), 1, 0, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1670) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03f597c7-b511-4266-a10f-591bc27e4875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81509776-31bb-49c9-ab2b-27b855bc8f0d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9fc3e73-76c8-4f7d-b113-7a852719f669");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae6f0671-3321-41d3-8297-56b980eb1e3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c740be-527f-4cd1-ae16-7944dffd0a43");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7965cd5-c2da-4297-a417-1851c262184b");

            migrationBuilder.DeleteData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "KindFamilya",
                table: "Kinds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KindTeam",
                table: "Kinds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1df64233-d6d6-45a0-b0ab-d8f3952220c6", "3eee127a-aa17-4584-b5b8-a2dd18f9255a", "UserRole", "Admin", null },
                    { "35bef7d9-923a-4366-8fdc-a75a342120c7", "c4ac963b-6721-4287-9a6c-ef3277b9c114", "UserRole", "Editor", null },
                    { "588d8eea-367a-418d-a3c0-721005f6dc7b", "9a96a48b-aa21-426c-9f2e-dde3ced94871", "UserRole", "Creator", null },
                    { "790d7d6f-6d8c-4efc-9d79-5b6e2a888bec", "18f71a4d-2bff-4917-8378-4583cb027a82", "UserRole", "BasicUser", null },
                    { "99979c78-09f3-4fca-9e45-fd934f30304d", "0a36cbe1-327d-46ec-b2a8-1c6e5a1d40a8", "UserRole", "MidUser", null },
                    { "9a035142-3b10-45b0-8c9d-45c72123a407", "b938e690-8d13-4ea0-911f-ca72e05ed8f8", "UserRole", "HighUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6997), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6998) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7003), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7005), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7007), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7008), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7009), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7011), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7013), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7014), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7015), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7016), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7017), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7019), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7021), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7022), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7023), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7025), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7026), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7027), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7028), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7029), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7031), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7034), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7035), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7037), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7039), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7041), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7042), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7043), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7044), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7046), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7047), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7048), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7049), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7052), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7055), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7056), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7058), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7059), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7061), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7064), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7066), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7067), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7068), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7070), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7071), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7072), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7073), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7074), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7076), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7077), new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7077) });
        }
    }
}
