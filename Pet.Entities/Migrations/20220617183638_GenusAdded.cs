using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class GenusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fa0ff65-960c-4907-ba1d-cb8215742c78");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57367e34-314a-4dcc-a40f-3b2bf3148263");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0a4ebe2-5d49-4b1a-ace9-f6e2aa9e6d54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81ef1e2-3d74-4695-84ef-3b596503963b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3351050-dd2e-4c54-a8ba-bf1d9b322f61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4e682ca-1615-4e36-9042-4c23bb46f88b");

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

            migrationBuilder.InsertData(
                table: "Genus",
                columns: new[] { "Id", "CreateTime", "GenusName", "UpdateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6739), "Amerikan Shorthair", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6748) },
                    { 2, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6749), "American Curl", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6749) },
                    { 3, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6750), "Balinese", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6751) },
                    { 4, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6752), "California Spangled", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6752) },
                    { 5, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6753), "Chartreux", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6754) },
                    { 6, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6754), "Ragdoll Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6755) },
                    { 7, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6755), "Mavi Rus kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6756) },
                    { 8, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6757), "Maine Coon", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6757) },
                    { 9, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6758), "İran kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6758) },
                    { 10, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6759), "British Shorthair", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6759) },
                    { 11, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6760), "California Spangled", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6760) },
                    { 12, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6761), "Munchkin", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6762) },
                    { 13, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6762), "Scottish Fold", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6763) },
                    { 14, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6763), "Norveç Orman Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6764) },
                    { 15, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6765), "Sibirya Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6765) },
                    { 16, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6766), "Savannah", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6766) },
                    { 17, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6767), "Amerikan Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6767) },
                    { 18, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6768), "Exotic Shorthair", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6768) },
                    { 19, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6769), "Ankara kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6770) },
                    { 20, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6771), "Himalayan Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6772) },
                    { 21, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6773), "Kısa Tüylü Kedi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6773) },
                    { 22, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6774), "Birman Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6774) },
                    { 23, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6775), "Habeş Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6775) },
                    { 24, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6776), "Bombay Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6776) },
                    { 25, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6777), "Kinkalow", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6778) },
                    { 26, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6778), "Oriental Shorthair", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6779) },
                    { 27, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6779), "Ragamuffin", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6780) },
                    { 28, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6782), "Somali Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6782) },
                    { 29, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6783), "Singapura", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6783) },
                    { 30, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6784), "British Longhair", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6785) },
                    { 31, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6785), "Toyger", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6786) },
                    { 32, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6786), "Van Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6787) },
                    { 33, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6788), "manks kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6788) },
                    { 34, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6789), "Donskoy Kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6789) },
                    { 35, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6790), "Havana kedisi", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6791) },
                    { 36, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6792), "Ocicat", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6792) }
                });

            migrationBuilder.InsertData(
                table: "Genus",
                columns: new[] { "Id", "CreateTime", "GenusName", "UpdateTime" },
                values: new object[] { 37, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6793), "Balinese", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.InsertData(
                table: "Genus",
                columns: new[] { "Id", "CreateTime", "GenusName", "UpdateTime" },
                values: new object[] { 38, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6794), "Laperm", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.InsertData(
                table: "Genus",
                columns: new[] { "Id", "CreateTime", "GenusName", "UpdateTime" },
                values: new object[] { 39, new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6795), "Selkirk Rex", new DateTime(2022, 6, 17, 21, 36, 38, 414, DateTimeKind.Local).AddTicks(6796) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3fa0ff65-960c-4907-ba1d-cb8215742c78", "781aec46-4663-48a3-8866-affbed7459cd", "UserRole", "MidUser", null },
                    { "57367e34-314a-4dcc-a40f-3b2bf3148263", "014b4c78-6ca0-4865-be8c-103d6fe3a589", "UserRole", "Creator", null },
                    { "a0a4ebe2-5d49-4b1a-ace9-f6e2aa9e6d54", "d623babd-aeba-4544-91b7-b40376448edc", "UserRole", "Admin", null },
                    { "b81ef1e2-3d74-4695-84ef-3b596503963b", "cf0a4b56-d93f-4bc0-867f-e6c80a2d888c", "UserRole", "BasicUser", null },
                    { "e3351050-dd2e-4c54-a8ba-bf1d9b322f61", "cc8aad1d-6ac3-4be9-9c0e-ee18214d32dc", "UserRole", "HighUser", null },
                    { "f4e682ca-1615-4e36-9042-4c23bb46f88b", "50722247-8305-4f9d-a1de-c19325d827c4", "UserRole", "Editor", null }
                });
        }
    }
}
