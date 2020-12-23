using Microsoft.EntityFrameworkCore.Migrations;

namespace ParsRollcall.Persistence.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_RollCalls_RollCallId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RollCallId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RollCallId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RollCalls",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RollCalls_UserId",
                table: "RollCalls",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RollCalls_AspNetUsers_UserId",
                table: "RollCalls",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RollCalls_AspNetUsers_UserId",
                table: "RollCalls");

            migrationBuilder.DropIndex(
                name: "IX_RollCalls_UserId",
                table: "RollCalls");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RollCalls");

            migrationBuilder.AddColumn<int>(
                name: "RollCallId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RollCallId",
                table: "AspNetUsers",
                column: "RollCallId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_RollCalls_RollCallId",
                table: "AspNetUsers",
                column: "RollCallId",
                principalTable: "RollCalls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
