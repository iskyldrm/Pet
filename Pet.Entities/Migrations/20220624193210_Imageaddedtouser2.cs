using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Imageaddedtouser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "ImageUserId",
                table: "Images",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_ImageUserId",
                table: "Images",
                column: "ImageUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_AspNetUsers_ImageUserId",
                table: "Images",
                column: "ImageUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_AspNetUsers_ImageUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ImageUserId",
                table: "Images");

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

            migrationBuilder.DropColumn(
                name: "ImageUserId",
                table: "Images");

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
    }
}
