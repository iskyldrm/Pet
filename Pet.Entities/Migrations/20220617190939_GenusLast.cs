using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class GenusLast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31033917-ce26-4472-aa0b-22ad692ab1e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c7cdba9-7d0a-4650-87cb-2900529df2bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "546712bf-5df4-474a-a357-9e4b997d5353");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ec2495d-cae6-4161-bc2b-4513a9a03c6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1962c61-8529-494e-97fc-a84deb378129");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3d7b59b-0761-4f13-bd69-46fc5d88682f");

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
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7044), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7046), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7047), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7048), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7049), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7050), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7052), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7053), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7054), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7055), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7056), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7058), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7059), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7060), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7061), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7062), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7064), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7065), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7066), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7067), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7068), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7070), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7071), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7072), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7073), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7074), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7076), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7077), false, new DateTime(2022, 6, 17, 22, 9, 39, 331, DateTimeKind.Local).AddTicks(7077) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31033917-ce26-4472-aa0b-22ad692ab1e8", "4cda01b0-4fd9-479e-bb00-258823f1c643", "UserRole", "HighUser", null },
                    { "3c7cdba9-7d0a-4650-87cb-2900529df2bf", "54cc9ae3-94fa-4f64-9047-6466208961de", "UserRole", "Admin", null },
                    { "546712bf-5df4-474a-a357-9e4b997d5353", "1fb95816-ba35-4a95-81ea-c5c19c23e647", "UserRole", "Editor", null },
                    { "7ec2495d-cae6-4161-bc2b-4513a9a03c6b", "0d028cf4-438d-4c8d-b2ca-9054e41ca4d8", "UserRole", "MidUser", null },
                    { "a1962c61-8529-494e-97fc-a84deb378129", "32c5ae16-f903-4529-984b-67f60926edd3", "UserRole", "Creator", null },
                    { "f3d7b59b-0761-4f13-bd69-46fc5d88682f", "97ae8ad6-1085-470f-8929-6848031ab029", "UserRole", "BasicUser", null }
                });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2182), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2195), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2197), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2198), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2201), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2203), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2204), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2205), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2208), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2213), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2215), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2216), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2217), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2218), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2221), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2221) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2222), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2225), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2226), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2227), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2231), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2233), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2234), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2235), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2236), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2238), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2239), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2242), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2243), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2244), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2245), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2247), new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2248), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2249), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2250), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2252), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2253), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2254), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2255), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2257), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2258), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2259), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2261), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2262), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2263), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2264), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2266), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2267), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2268), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2269), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2271), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2272), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2273), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2274), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2276), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2277), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2278), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2279), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2281), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Genus",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreateTime", "GenusType", "UpdateTime" },
                values: new object[] { new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2282), true, new DateTime(2022, 6, 17, 22, 7, 33, 586, DateTimeKind.Local).AddTicks(2283) });
        }
    }
}
