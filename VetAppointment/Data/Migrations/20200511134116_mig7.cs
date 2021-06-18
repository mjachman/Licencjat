using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d3404b1-0cbb-45c8-a435-3d695939ab9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1293288d-4e5f-47e6-beda-a5ea5cd76add");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d9135c9-df85-45c0-8df5-742526e60515");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da8bfec3-68c1-4a42-988e-73832937dfaf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d3404b1-0cbb-45c8-a435-3d695939ab9e", "b84df23f-2815-433a-84d6-df029c086080", "Admin", "ADMIN" },
                    { "1293288d-4e5f-47e6-beda-a5ea5cd76add", "6cec38f5-259b-4835-8e94-169266773a88", "User", "USER" },
                    { "2d9135c9-df85-45c0-8df5-742526e60515", "8861be10-2238-4aeb-990d-4c091d0c7294", "Vet", "VET" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Surname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da8bfec3-68c1-4a42-988e-73832937dfaf", 0, null, "78aa8523-48b3-4881-a43b-5f4a1fca5e84", "admin@admin.com", true, false, null, "Admin", null, null, "AQAAAAEAACcQAAAAEOCicOq21f4K/3DLnQbT7Anjf3fjLr0W74L8ryNELQgJ4vfB11rxHgs2NoiWZtOsUg==", null, false, "6e41946d-8370-43e6-8c52-cc396d68554b", null, false, null });
        }
    }
}
