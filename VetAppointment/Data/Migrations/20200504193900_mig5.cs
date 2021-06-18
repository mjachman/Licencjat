using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Appointments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "369cee38-5339-4467-aac1-7e9018579f4e", "1d131e97-9af6-472e-8e3d-8f7a1c258ab6", "Admin", "ADMIN" },
                    { "012c0e89-0c87-4f3f-90b6-f57c135ad23b", "01c972be-1f09-45d1-a932-aad3c893b268", "User", "USER" },
                    { "eebd53c5-5ebb-4806-b708-17b8cfc80279", "249f5ddd-6fc0-43fe-ba28-dc6884e79ceb", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8c3e289-2440-4171-917f-1aa5ee44527a", 0, null, "c95b7aac-5171-4f27-83ba-e2751eef3bf3", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAENzX8yov5E8rwn/Dh/iaq/cB1p5WmSeQN9vDT2svO56GguPoU/w2Fy02QOA3PVkk2A==", null, false, "39950dc3-1716-44a5-ab08-e95f558a9f67", null, false, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "012c0e89-0c87-4f3f-90b6-f57c135ad23b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "369cee38-5339-4467-aac1-7e9018579f4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eebd53c5-5ebb-4806-b708-17b8cfc80279");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8c3e289-2440-4171-917f-1aa5ee44527a");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Appointments");

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
    }
}
