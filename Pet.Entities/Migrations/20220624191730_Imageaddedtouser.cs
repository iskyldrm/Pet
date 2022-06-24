using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Imageaddedtouser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "350dc762-1887-4707-a68f-761d2f03cdc6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b34c3ec-966e-4ddd-87ce-8954a15755dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "554eeedf-a075-4595-8c33-14831b833260");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a9ddfc3-3d78-4907-9a94-f8db940ef905");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faf8699-f5e9-4282-882c-08d74366e533");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c946b0c8-98bc-4216-9358-32ba94a39b2b");

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "626333d8-e129-4854-abca-536cd86899ea", "f05d6be3-2e5d-4a73-9d09-6289dcc46b46", "UserRole", "Creator", null },
                    { "76bd3236-8251-45c0-b1c6-48ac311a65d1", "2bfef952-eab6-4258-93a8-5aeb48d42a46", "UserRole", "MidUser", null },
                    { "b78e9b01-72fe-4fbf-abc9-45e18ad2c5dc", "ec2e5c8a-68e1-432e-b5e3-8b6b1acf0fa1", "UserRole", "HighUser", null },
                    { "cb3d57a3-5563-40bb-9301-d685f72e4836", "f1e788e1-196a-4f29-938b-57fc3f89fbab", "UserRole", "BasicUser", null },
                    { "e48703d2-876c-4db1-9b07-f73ae5fed3bb", "60052a00-f961-4990-94f1-9d89e3d5f6c6", "UserRole", "Editor", null },
                    { "e7943686-3e24-44af-9be1-33123f91453d", "6378cefc-97fa-4e0f-b5d1-20dd483cc260", "UserRole", "Admin", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7013), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7015), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7017), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7019), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7021), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7022), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7023), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7024), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7025), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7027), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7028), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7029), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7032), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7033), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7034), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7035), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7036), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7038), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7039), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7041), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7042), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7044), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7044) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7045), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7046), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7047), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7048), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7051), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7052), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7056), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7058), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7059), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7061), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7062), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7063), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7064), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7065), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7067), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7068), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7069), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7071), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7072), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7073), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7074), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7075), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7077), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7078), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7079), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7080), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7081), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7083), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7084), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7085), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7086), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7088), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7089), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7091), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7093), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7094), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7094) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7324), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7326), new DateTime(2022, 6, 24, 22, 17, 29, 923, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "626333d8-e129-4854-abca-536cd86899ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76bd3236-8251-45c0-b1c6-48ac311a65d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b78e9b01-72fe-4fbf-abc9-45e18ad2c5dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb3d57a3-5563-40bb-9301-d685f72e4836");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e48703d2-876c-4db1-9b07-f73ae5fed3bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7943686-3e24-44af-9be1-33123f91453d");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "350dc762-1887-4707-a68f-761d2f03cdc6", "1e2df34c-d1f3-4e88-adaf-f085ec59e8e0", "UserRole", "MidUser", null },
                    { "3b34c3ec-966e-4ddd-87ce-8954a15755dc", "60d9e452-43fa-45b9-87d2-06d2844f0dd8", "UserRole", "BasicUser", null },
                    { "554eeedf-a075-4595-8c33-14831b833260", "5e483bce-b7fb-4c2e-a55a-226a4547e241", "UserRole", "Admin", null },
                    { "6a9ddfc3-3d78-4907-9a94-f8db940ef905", "1b38d1b8-3adc-4b32-b8bb-cb39a7e83669", "UserRole", "Editor", null },
                    { "8faf8699-f5e9-4282-882c-08d74366e533", "5b203b2c-d1d5-4c7d-ad21-02cb27010b34", "UserRole", "HighUser", null },
                    { "c946b0c8-98bc-4216-9358-32ba94a39b2b", "54c6735e-d41f-4f6a-956e-c837608e7f28", "UserRole", "Creator", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(531), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(545), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(545) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(546), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(547), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(549), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(550), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(551), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(552) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(553), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(554), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(556), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(557), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(558), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(559), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(561), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(562), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(563), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(564), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(565), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(567), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(569), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(570), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(571), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(573), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(574), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(576), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(577), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(578), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(580), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(581), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(582), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(583), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(584), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(586), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(587), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(588), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(588) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(589), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(590), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(592), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(593), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(594), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(595), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(596), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(598), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(599), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(601), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(602) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(603), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(604), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(605), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(606) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(606), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(608), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(608) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(609), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(610), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(611), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(612), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(614), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(615), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(616), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(617), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(618), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(620), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(621), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(622), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(623), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(831), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(833), new DateTime(2022, 6, 23, 22, 44, 1, 660, DateTimeKind.Local).AddTicks(834) });
        }
    }
}
