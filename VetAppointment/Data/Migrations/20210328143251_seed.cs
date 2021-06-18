using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f4e7da-57e8-4bc0-bda7-fa594323496a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "477d122e-7a60-4456-9d8f-10ca56c98481");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b849011-2776-43e3-a2ea-3e709158cb40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "548a9e9e-acaa-4d80-91ea-42351abf0ff4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d8ccf53-0863-4e26-9f40-ab8b08e9b744");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a975a5ff-0384-46c1-ab05-635019e9c4f9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "477d122e-7a60-4456-9d8f-10ca56c98481", "658c77e9-70b5-4fdb-951b-d6713128f6dc", "Admin", "ADMIN" },
                    { "7b849011-2776-43e3-a2ea-3e709158cb40", "617a2476-db2f-415b-be81-52982c8865f1", "User", "USER" },
                    { "17f4e7da-57e8-4bc0-bda7-fa594323496a", "330c61d7-009e-48be-9f16-bc6cd401e2e9", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7d8ccf53-0863-4e26-9f40-ab8b08e9b744", 0, null, "b2d1838e-a42b-4e07-b692-9c955e5fb258", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEPytSgW+ZNCTy6XhDa0iOOlI9K7H/MfFa3VmmSDeNJP3ktpw2QUY20dYb3I8hOcLjg==", null, false, "64832471-8fc6-4fed-85f5-1aad394c2629", null, false, "admin@admin.com" },
                    { "548a9e9e-acaa-4d80-91ea-42351abf0ff4", 0, "Gdynia,ul. Rdestowa 15", "e33cd049-d463-49d7-9e31-f66e66d37c5b", "wet@wet.pl", true, false, null, "Artur", null, null, "AQAAAAEAACcQAAAAEG6C4h9MroW2xeV23muQmdU739YGhUu7KtxdpRjdzddtMCJ+zBabx52h7S4jxLcuFg==", null, false, "f49e934f-b298-4e62-b411-777e5005d735", "Głowacki", false, "wet@wet.pl" },
                    { "a975a5ff-0384-46c1-ab05-635019e9c4f9", 0, null, "ca40bc04-b13d-4f94-a6d6-3fa81826adf4", "karol@karol.pl", true, false, null, "Karol", null, null, "AQAAAAEAACcQAAAAEAuYDk864OyB+zDJ/c9EmiB7aAmMd/U2+PfzFqkf7+xQb1ElAph8XbgE0qlBpduhfg==", null, false, "9e2bb0cb-0752-4ada-bfe5-a933686f44f1", "Baczyna", false, "karol@karol.pl" }
                });
        }
    }
}
