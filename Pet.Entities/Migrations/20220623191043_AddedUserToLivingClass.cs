using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class AddedUserToLivingClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3421e807-d478-48bb-93a8-664239628c6f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "569cc95a-a6d3-4ce9-addf-03f217cbb4b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d69c9e5-77cd-452c-a873-16af1fb3a275");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b643195e-1b2a-451e-a81e-4732d00abe24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c434af87-edf7-453b-a4f3-daa35deb6516");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbbc7890-9399-4073-a064-f91eba1dcf9d");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3421e807-d478-48bb-93a8-664239628c6f", "d117e3b5-d24b-4bfa-9c79-61237053f818", "UserRole", "HighUser", null },
                    { "569cc95a-a6d3-4ce9-addf-03f217cbb4b2", "6d846fdd-e500-4140-ad3c-8877186159de", "UserRole", "MidUser", null },
                    { "8d69c9e5-77cd-452c-a873-16af1fb3a275", "cac3a7c8-9a27-4299-b88f-c634ab7320fc", "UserRole", "Creator", null },
                    { "b643195e-1b2a-451e-a81e-4732d00abe24", "250763b4-a5b8-40d0-a999-f76922105e38", "UserRole", "Admin", null },
                    { "c434af87-edf7-453b-a4f3-daa35deb6516", "749bcc4f-774f-4255-9eda-251ec5fa2d6a", "UserRole", "Editor", null },
                    { "cbbc7890-9399-4073-a064-f91eba1dcf9d", "0313fa0b-7335-4648-89fe-68018e4fc244", "UserRole", "BasicUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4879), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4900), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4902), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4904), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4905), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4906), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4907), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4908), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4910), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4911), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4912), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4913), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4916), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4917), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4918), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4921), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4923), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4924), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4926), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4928), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4929), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4930), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4932), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4933), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4934), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4937), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4937) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4939), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4940), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4944), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4945), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4947), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4948), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4948) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4949), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4950), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4951), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4953), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4953) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4954), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4955), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4956), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4958), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4959), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4960), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4963), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4964), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4965), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4967), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4967) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4968), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4969), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4970), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4972), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4973), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4974), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4975), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4976), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4978), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4979), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4981), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5411), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5413), new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5414) });
        }
    }
}
