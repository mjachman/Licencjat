using Microsoft.EntityFrameworkCore.Migrations;

namespace VetAppointment.Data.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_ParentMessagMessageID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ParentMessagMessageID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ParentMessagMessageID",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ParentMessageMessageID",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "Messages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ParentMessageMessageID",
                table: "Messages",
                column: "ParentMessageMessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_ParentMessageMessageID",
                table: "Messages",
                column: "ParentMessageMessageID",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_ParentMessageMessageID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ParentMessageMessageID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ParentMessageMessageID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "Messages");

            migrationBuilder.AddColumn<int>(
                name: "ParentMessagMessageID",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ParentMessagMessageID",
                table: "Messages",
                column: "ParentMessagMessageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_ParentMessagMessageID",
                table: "Messages",
                column: "ParentMessagMessageID",
                principalTable: "Messages",
                principalColumn: "MessageID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
