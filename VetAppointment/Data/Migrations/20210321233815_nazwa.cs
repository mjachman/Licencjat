using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class nazwa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "91dcbde1-9d59-443a-a1b7-9464982e40f0", "bfd9d70c-535e-41b0-8df5-21305ef7c55a", "Admin", "ADMIN" },
                    { "6673fc1e-ceb8-4b7f-8ffd-7564543845fd", "e5a0e866-40a3-4d8f-9936-f3799439ef0f", "User", "USER" },
                    { "45c06f68-9654-4ca8-b570-819563185ab9", "2aa51981-c1d1-4b7d-84ab-648f5c6ee219", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7861b8cb-a642-4ac4-b51c-ea0672ace734", 0, null, "baf52681-ab69-4c7b-9ebc-02a222c0fe86", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEP5Vbmw2yb24xym6ISruOzozBbs5zdHjLn5dbA6A7RcJIHEoyRnORfnfvEEQaTfKvQ==", null, false, "afe8338e-ab61-414a-91ba-b64a265f62b7", null, false, null },
                    { "8f61dff1-39d4-4412-8199-eb26aa7855f6", 0, "Gdynia,ul. Rdestowa 15", "ba66454d-13c1-43bf-9d5c-8eb2cc56851d", "wet@wet.pl", true, false, null, "Artur", null, null, "AQAAAAEAACcQAAAAEOexU7Ze6MCO/aatuAC9NTTL+vWLu/gMuQcLWxMikdnjirQ4RZRC6G0had1qi5LGDA==", null, false, "cdfb1fbc-fb5a-4d64-bef8-a1da340df8e8", "Głowacki", false, null },
                    { "62158d1f-4294-4afc-9d27-5eed099b1d74", 0, null, "6fa3d058-73f8-46d8-9aa6-8c0670b4cf7b", "karol@karol.pl", true, false, null, "Karol", null, null, "AQAAAAEAACcQAAAAEO/xJVxEa/IlOhVI8537cdih51hOcbZhhCM3us2OBRZPpPIWDqNjgaT0mvlG0AqCEQ==", null, false, "75526c83-02fb-4106-9e8b-b54029b0773f", "Baczyna", false, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45c06f68-9654-4ca8-b570-819563185ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6673fc1e-ceb8-4b7f-8ffd-7564543845fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91dcbde1-9d59-443a-a1b7-9464982e40f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62158d1f-4294-4afc-9d27-5eed099b1d74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7861b8cb-a642-4ac4-b51c-ea0672ace734");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f61dff1-39d4-4412-8199-eb26aa7855f6");

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
    }
}
