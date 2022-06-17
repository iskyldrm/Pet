using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pet.Entities.Migrations
{
    public partial class Initdb2 : Migration
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
                keyValue: "208acc29-d90c-4b30-977d-203228338612");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27a47ab7-889c-4bda-870e-e0a0176ebb8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49b7805a-f62a-4b5f-907b-6002dd8299e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a80deb-fcaa-4bfe-adba-f1c41f521e1b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c382ac19-5153-468d-b727-08773397b5bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f366c497-2cff-455b-ae70-dcc0fc6cc7ae");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "AspNetUsers");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ImageId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "208acc29-d90c-4b30-977d-203228338612", "b3f47778-6c6b-4608-8f78-2e4b99359f23", "UserRole", "Creator", null },
                    { "27a47ab7-889c-4bda-870e-e0a0176ebb8f", "8358f455-e550-4c89-9f86-353488c3ad3f", "UserRole", "MidUser", null },
                    { "49b7805a-f62a-4b5f-907b-6002dd8299e8", "dc445c9f-1b20-4112-b9bb-761d1b00f58e", "UserRole", "BasicUser", null },
                    { "a1a80deb-fcaa-4bfe-adba-f1c41f521e1b", "ee30d596-7dad-474b-b21b-7c2bf8f06583", "UserRole", "Editor", null },
                    { "c382ac19-5153-468d-b727-08773397b5bb", "1b31a7dc-ac6b-442c-bdce-8584f4e47dde", "UserRole", "Admin", null },
                    { "f366c497-2cff-455b-ae70-dcc0fc6cc7ae", "ca932052-65ff-461b-8eec-1d97cd4ed324", "UserRole", "HighUser", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Images_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
