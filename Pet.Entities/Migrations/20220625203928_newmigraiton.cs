using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class newmigraiton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "LivingId",
                table: "Adverts",
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
                    { "3ffb0003-45e4-4af3-a96b-66170449a20d", "3a157a4a-78c8-4dba-b8c8-71788fca6eb6", "UserRole", "Editor", null },
                    { "4e885d36-ff22-4f78-8721-12f94c935956", "520dce82-3683-486e-8888-c1effd99d0a0", "UserRole", "MidUser", null },
                    { "5509bc30-74c6-4240-95e3-263ac6abdaf1", "e0c190b0-4f72-49c6-9ae0-e6308bb4c5e3", "UserRole", "HighUser", null },
                    { "672e30f7-fab4-4f34-8015-014921e05ed8", "a6193ea9-bdac-4b38-9526-8ca3b9ba07bf", "UserRole", "Admin", null },
                    { "75b56726-8dcd-4a29-8041-59656057b4b4", "30d8de55-604c-48d1-ad61-0784488c350c", "UserRole", "BasicUser", null },
                    { "8bfc911d-b7ad-4622-b265-7c59111775ee", "e383ffdc-ba2e-4e9b-8ebe-3547e9a4dbd3", "UserRole", "Creator", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(8987), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9006), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9007), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9009), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9014), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9017), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9019), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9022), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9024), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9026), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9026) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9029), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9031), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9033), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9034), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9036), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9037), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9039), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9094), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9096), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9098), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9103), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9107), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9112), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9115), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9117), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9119), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9122), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9124), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9124) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9125), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9127), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9129), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9131), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9131) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9132), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9136), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9136) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9137), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9139), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9141), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9143), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9144), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9146), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9148), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9153), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9155), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9159), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9166), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9168), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9169), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9171), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9467), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9469) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 6, 25, 23, 39, 28, 64, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts",
                column: "LivingId",
                principalTable: "Livings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ffb0003-45e4-4af3-a96b-66170449a20d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e885d36-ff22-4f78-8721-12f94c935956");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5509bc30-74c6-4240-95e3-263ac6abdaf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "672e30f7-fab4-4f34-8015-014921e05ed8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75b56726-8dcd-4a29-8041-59656057b4b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8bfc911d-b7ad-4622-b265-7c59111775ee");

            migrationBuilder.AlterColumn<Guid>(
                name: "LivingId",
                table: "Adverts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts",
                column: "LivingId",
                principalTable: "Livings",
                principalColumn: "Id");
        }
    }
}
