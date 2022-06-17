using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class DeRacial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livings_Racials_RacialId",
                table: "Livings");

            migrationBuilder.DropTable(
                name: "Racials");

            migrationBuilder.DropIndex(
                name: "IX_Livings_RacialId",
                table: "Livings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0628f3a1-90e5-4e60-8eae-f80e431ec9b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "086c741b-835c-46ce-8346-ea86cf9966b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2864b71d-2b4d-49f2-ad7c-a6c1cdc0630d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e243413-755b-40c1-a52d-f85976a39f97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96420ad8-5075-4b4d-b100-20b47773a356");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff246bcf-b98e-496d-99e1-f8c9f0187a9b");

            migrationBuilder.DropColumn(
                name: "RacialId",
                table: "Livings");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "RacialId",
                table: "Livings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Racials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RacialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racials", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0628f3a1-90e5-4e60-8eae-f80e431ec9b8", "74a301bc-a112-4698-8677-7ad206655b38", "UserRole", "Creator", null },
                    { "086c741b-835c-46ce-8346-ea86cf9966b8", "b38a7e42-e4af-4868-a2c3-ec477edccd48", "UserRole", "HighUser", null },
                    { "2864b71d-2b4d-49f2-ad7c-a6c1cdc0630d", "877ab6cb-3149-4208-aaed-7db31ec4617b", "UserRole", "Admin", null },
                    { "3e243413-755b-40c1-a52d-f85976a39f97", "4f1d0453-5614-4f5e-93f7-b76f1a8ab905", "UserRole", "BasicUser", null },
                    { "96420ad8-5075-4b4d-b100-20b47773a356", "24f2c7ff-ade2-4212-8376-94c9ff26f440", "UserRole", "Editor", null },
                    { "ff246bcf-b98e-496d-99e1-f8c9f0187a9b", "30b923bf-d357-4dbe-a2e4-3c4a271cbc7d", "UserRole", "MidUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6739), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6749), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6752), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6753), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6755), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6757), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6758), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6761), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6762) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6762), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6763), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6765), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6765) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6766), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6766) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6767), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6768), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6768) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6775), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6776), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6777), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6778), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6779), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6782), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6785), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6792), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6793), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6794), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6795), new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.CreateIndex(
                name: "IX_Livings_RacialId",
                table: "Livings",
                column: "RacialId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livings_Racials_RacialId",
                table: "Livings",
                column: "RacialId",
                principalTable: "Racials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
