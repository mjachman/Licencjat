using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class migracjaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "fd410629-a5da-4d48-8139-3053774967eb", "8a25f4a2-458c-476c-a3cd-bcba989aae9b", "Admin", "ADMIN" },
                    { "70df7c6b-2935-46d7-ba4a-292366762c1d", "3f39b9ad-9c30-4dea-90f9-4f7cb67bd133", "User", "USER" },
                    { "3fde1b2a-c15c-4514-8ea2-36f4c0dd3330", "b1c3df61-f1d8-4f4b-8c69-a365a9ca7c65", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06c3ba17-788e-4eba-8b2b-1617d26a3cdc", 0, null, "f1390a88-bc65-448e-b577-a0a7e4306ac6", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEOVi7Dh/q2UTvtwjoc6Q6LS8HsdQg1yYrYNw37QKQ7gOlXaydEDR6huYJRD67aN4hw==", null, false, "1c7e0176-87aa-4e9f-ac28-21278e2c6ebb", null, false, null },
                    { "aaaa3c0e-c6cc-4bc7-b79a-a6d6565fe170", 0, "Gdynia,ul. Rdestowa 15", "925830b0-33be-4e45-adf5-86283cb989c6", "wet@wet.pl", true, false, null, "Artur", null, null, "AQAAAAEAACcQAAAAEGFQhYbskAyRZ3nMzHh8SIaIq2Zgz+N/lzoK77UJRpns1SOauU+x33y5z8wy0shwsg==", null, false, "d024e363-ac88-44d6-b3c2-e8df737601b1", "Głowacki", false, null },
                    { "f159fb92-5afe-4454-a066-84bb4ab610c9", 0, null, "5124eacc-1051-4497-9911-f499266ac80f", "karol@karol.pl", true, false, null, "Karol", null, null, "AQAAAAEAACcQAAAAEBLMo1YxXpQS5K4GIHkQt55ZSQrQFZNzNjJAvUh3u6EGnB+2lJQkbgTmGXbFKH0tFA==", null, false, "ce280474-b21c-4b94-aa07-ed4de487cdc2", "Baczyna", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fde1b2a-c15c-4514-8ea2-36f4c0dd3330");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70df7c6b-2935-46d7-ba4a-292366762c1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd410629-a5da-4d48-8139-3053774967eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06c3ba17-788e-4eba-8b2b-1617d26a3cdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaaa3c0e-c6cc-4bc7-b79a-a6d6565fe170");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f159fb92-5afe-4454-a066-84bb4ab610c9");

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
    }
}
