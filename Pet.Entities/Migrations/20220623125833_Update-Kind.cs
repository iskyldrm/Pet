using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class UpdateKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "KindName",
                table: "Kinds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreateTime", "KindName", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5411), "Kedi", new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5412) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "KindName", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5413), "Köpek", new DateTime(2022, 6, 23, 15, 58, 33, 334, DateTimeKind.Local).AddTicks(5414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "KindName",
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

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Kinds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1668), new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.InsertData(
                table: "Kinds",
                columns: new[] { "Id", "CreateTime", "Familya", "Team", "UpdateTime" },
                values: new object[] { 3, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1670), 1, 0, new DateTime(2022, 6, 17, 22, 26, 22, 128, DateTimeKind.Local).AddTicks(1670) });
        }
    }
}
