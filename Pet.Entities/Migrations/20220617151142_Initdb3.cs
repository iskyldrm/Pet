using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Initdb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10575fb3-cb54-44ac-bcff-27f647ae7d48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2010dc39-9bec-4e25-8689-95cb3fbf2a6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d6e984b-bf88-4a45-83c6-fa370d1b4a46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9385c002-11ef-41ad-9f35-06278e2eceba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "995868fc-72b4-4b7f-92cd-4fc2002d049a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff670f64-b0e0-4587-8ac7-d4ad07c9ab13");

            migrationBuilder.AddColumn<Guid>(
                name: "LivingId",
                table: "Adverts",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_LivingId",
                table: "Adverts",
                column: "LivingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts",
                column: "LivingId",
                principalTable: "Livings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Livings_LivingId",
                table: "Adverts");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_LivingId",
                table: "Adverts");

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

            migrationBuilder.DropColumn(
                name: "LivingId",
                table: "Adverts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10575fb3-cb54-44ac-bcff-27f647ae7d48", "29b87fe1-f8aa-44e8-a43b-11795185cbbd", "UserRole", "MidUser", null },
                    { "2010dc39-9bec-4e25-8689-95cb3fbf2a6b", "c12c723c-c22c-4383-87ac-0616e89e3d37", "UserRole", "Admin", null },
                    { "3d6e984b-bf88-4a45-83c6-fa370d1b4a46", "7e7d28c3-3334-4bb6-915f-8fbb541253f0", "UserRole", "BasicUser", null },
                    { "9385c002-11ef-41ad-9f35-06278e2eceba", "b1850340-9e95-4bc9-b22f-494f0e0296af", "UserRole", "HighUser", null },
                    { "995868fc-72b4-4b7f-92cd-4fc2002d049a", "6e7d7040-5e6f-48e2-87d4-fced1c0c3ec9", "UserRole", "Creator", null },
                    { "ff670f64-b0e0-4587-8ac7-d4ad07c9ab13", "3d5cc9c7-7d85-4b15-836c-4f09f1fcafa2", "UserRole", "Editor", null }
                });
        }
    }
}
