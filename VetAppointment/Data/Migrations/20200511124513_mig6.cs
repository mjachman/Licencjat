using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentMessagMessageID = table.Column<int>(nullable: true),
                    MessageBody = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ViewedDate = table.Column<DateTime>(nullable: false),
                    SenderId = table.Column<string>(nullable: true),
                    ReceiverId = table.Column<string>(nullable: true),
                    isViewed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_Messages_ParentMessagMessageID",
                        column: x => x.ParentMessagMessageID,
                        principalTable: "Messages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ParentMessagMessageID",
                table: "Messages",
                column: "ParentMessagMessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

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
    }
}
