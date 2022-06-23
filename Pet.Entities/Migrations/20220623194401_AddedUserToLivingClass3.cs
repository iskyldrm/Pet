using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class AddedUserToLivingClass3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Adverts_AdvertId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01043ff7-54ae-44bb-afb2-3306338c7e92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aee526b-4b65-4467-876a-78259f968211");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a97f3aa-e557-4322-a941-0b5ff0492a0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8eb48cd1-9615-4b66-9939-2ff5f6cc8e1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e06fd5d-eb3e-442b-a59f-e670e5356033");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f665815d-bef6-46f1-9a4f-3e45ecfee0c8");

            migrationBuilder.AlterColumn<Guid>(
                name: "AdvertId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Adverts_AdvertId",
                table: "Images",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Adverts_AdvertId",
                table: "Images");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "AdvertId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01043ff7-54ae-44bb-afb2-3306338c7e92", "46e26783-8389-4527-bce3-d4658081d9d0", "UserRole", "HighUser", null },
                    { "3aee526b-4b65-4467-876a-78259f968211", "5cdc2a90-8845-42d4-bebf-f96b15880635", "UserRole", "Editor", null },
                    { "5a97f3aa-e557-4322-a941-0b5ff0492a0e", "78d1dca0-cadf-4312-80f7-6e68c2b7018f", "UserRole", "Admin", null },
                    { "8eb48cd1-9615-4b66-9939-2ff5f6cc8e1b", "f0011cfa-dd19-4aa0-ab46-ba8e7837696b", "UserRole", "Creator", null },
                    { "9e06fd5d-eb3e-442b-a59f-e670e5356033", "9b42b233-5927-461c-b9e2-3ca267e3c19a", "UserRole", "BasicUser", null },
                    { "f665815d-bef6-46f1-9a4f-3e45ecfee0c8", "2614a24a-046d-4e7b-9319-ea8481008bfa", "UserRole", "MidUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9316), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9332), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9335), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9336), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9337), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9338), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9339), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9341), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9341) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9342), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9343), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9344), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9346), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9347), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9348), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9349), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9352), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9355), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9356) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9357), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9358), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9359), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9360), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9362), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9364), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9366), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9367), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9368), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9369) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9371), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9373), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9375) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9376), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9377), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9378), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9383), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9384), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9385), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9386), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9388), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9390), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9391) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9391), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9392), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9394), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9395), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9396), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9397), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9400), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9401), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9402), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9403), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9404), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9406), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9407), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9409), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9410), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9412), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9413), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9755), new DateTime(2022, 6, 23, 22, 32, 1, 282, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Adverts_AdvertId",
                table: "Images",
                column: "AdvertId",
                principalTable: "Adverts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
