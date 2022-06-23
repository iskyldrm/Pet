using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class AddedUserToLivingClass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livings_AspNetUsers_UserId",
                table: "Livings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15e038a9-28b3-4480-9f11-7bc30192cd13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49f40915-d544-4801-bc4f-7e088fb1f22e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fc0cfc2-2dbb-438d-b926-159d2804622b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "592a7c16-9faf-48cf-91ee-acd2e60f9f31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b899a57f-982f-40ac-af6c-7d0f766f56ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe09387f-ad46-4b92-bf73-cd2acd777cdc");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Livings",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
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
                name: "FK_Livings_AspNetUsers_UserId",
                table: "Livings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livings_AspNetUsers_UserId",
                table: "Livings");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Livings",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15e038a9-28b3-4480-9f11-7bc30192cd13", "31027fa9-bda4-47a6-a0b9-29cc9a3b8462", "UserRole", "Creator", null },
                    { "49f40915-d544-4801-bc4f-7e088fb1f22e", "eca8882f-b842-4b8c-8d63-7193adb34c72", "UserRole", "Admin", null },
                    { "4fc0cfc2-2dbb-438d-b926-159d2804622b", "2245adc6-4d95-492b-b0d8-a3ab7419071c", "UserRole", "MidUser", null },
                    { "592a7c16-9faf-48cf-91ee-acd2e60f9f31", "8d29ccb4-2e98-4e2b-92cd-77ea1e95b4b4", "UserRole", "HighUser", null },
                    { "b899a57f-982f-40ac-af6c-7d0f766f56ba", "78071eb3-c1b5-4a92-960a-c1acac140543", "UserRole", "BasicUser", null },
                    { "fe09387f-ad46-4b92-bf73-cd2acd777cdc", "72e2606a-b1bd-49f0-bdcf-26ab0da68f73", "UserRole", "Editor", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2813), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2822) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2823), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2825), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2826), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2828), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2829), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2829) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2831), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2832), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2833), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2834) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2835), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2836), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2837), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2838), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2839), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2844), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2847), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2848), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2849), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2849) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2851), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2853), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2855), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2857), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2858), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2859) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2861), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2861) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2862), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2863), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2864), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2866), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2867), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2868), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2868) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2869), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2871) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2872), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2874), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2877), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2879), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2881), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2883) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2884), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2886), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2887), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2888) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2891), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2891) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2892), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2893), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2895), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2896), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2896) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2897), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2899), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2902), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(3138), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 6, 23, 22, 10, 43, 513, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.AddForeignKey(
                name: "FK_Livings_AspNetUsers_UserId",
                table: "Livings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
