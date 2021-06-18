using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f01bdc10-0693-4ecc-b855-38df9c5df539", "f2d9f849-6a1a-475c-9b5f-2a2b46757133", "Admin", "ADMIN" },
                    { "bb338015-30d1-4b77-af36-4c9c35165a38", "1f67ebb3-84af-4e02-8bc4-25d4741af4e7", "User", "USER" },
                    { "00b24b15-1f62-48ba-8b18-0ed8ab9f1628", "0d103960-cbba-45e3-bc16-951035505fc4", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5dc33699-ed15-454f-82f4-77a4be42a673", 0, null, "c3ff133c-ca6f-4d3d-9163-4ac472c5f042", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEP4ebkNRMdcxOOaP1WNLxKpDTUnBam2ejAopJ+yldVvK2piF2oAwnNvq38XSeWEtsg==", null, false, "29339955-2b8d-4a40-9d62-e56a56e567b7", null, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b24b15-1f62-48ba-8b18-0ed8ab9f1628");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb338015-30d1-4b77-af36-4c9c35165a38");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f01bdc10-0693-4ecc-b855-38df9c5df539");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dc33699-ed15-454f-82f4-77a4be42a673");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");
        }
    }
}
