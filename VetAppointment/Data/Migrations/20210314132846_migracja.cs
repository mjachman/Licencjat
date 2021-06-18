using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class migracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "56bec5c0-c631-4026-8a9f-5325c90067e1", "fade97a1-1a2b-4adb-a8b1-f333779226a1", "Admin", "ADMIN" },
                    { "00a194b8-2e4f-4dee-bdef-4540695c773a", "4f184716-d5c5-4eeb-90fa-e14245f5d2e7", "User", "USER" },
                    { "8786e3ec-37db-4e19-b0d2-c75ffc0eaec2", "4802e3b3-f137-404b-b143-bfe65e305d4a", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c3cc311e-e890-4344-a7d1-54d19ad1ec16", 0, null, "4f830947-c02b-484b-98de-75a45c76448f", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEOHlzk91GwJ1C9ifubH3qNsarAgYintc4dnS+8GRfoF+gTTNqlSgEF04hHDqxCfQxw==", null, false, "a6762fc1-929f-40c4-b5f5-2207d38157ff", null, false, null },
                    { "8265539d-6517-456f-9f9a-7d483520e9cd", 0, "Gdynia,ul. Rdestowa 15", "294a7e09-b5af-4d76-a705-408416d0306d", "wet@wet.pl", true, false, null, "Artur", null, null, "AQAAAAEAACcQAAAAECPg1Gt+hgZT5vyvmxWKz5H6qZKq2l7jVjJyKENG5egtfQ3MZYPXmZo5KVZBTh4fLw==", null, false, "fe915496-399c-4d4e-858e-73ea9b96b583", "Głowacki", false, null },
                    { "d07e7ed3-e8e6-4945-88ba-034e53e8a777", 0, null, "5792656b-b09c-4bfe-9b97-626a79b0c47f", "karol@karol.pl", true, false, null, "Karol", null, null, "AQAAAAEAACcQAAAAEPIPsy7G4hyVuZOAPJlCFV9IcqYJFYcoVQqQDR0wmZVbW9GEOMh0Es00QGMwpMiAbw==", null, false, "4862587f-2bce-46de-8dc1-d00a8948eb9f", "Baczyna", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00a194b8-2e4f-4dee-bdef-4540695c773a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56bec5c0-c631-4026-8a9f-5325c90067e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8786e3ec-37db-4e19-b0d2-c75ffc0eaec2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8265539d-6517-456f-9f9a-7d483520e9cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3cc311e-e890-4344-a7d1-54d19ad1ec16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d07e7ed3-e8e6-4945-88ba-034e53e8a777");
        }
    }
}
