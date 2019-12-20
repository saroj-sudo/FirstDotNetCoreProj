using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineApplication.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Companies_ReceiverId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_ReceiverId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "ReceiverAddress",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverComanyName",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverName",
                table: "Applications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiverAddress",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ReceiverComanyName",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "ReceiverName",
                table: "Applications");

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Applications",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ReceiverId",
                table: "Applications",
                column: "ReceiverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Companies_ReceiverId",
                table: "Applications",
                column: "ReceiverId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
