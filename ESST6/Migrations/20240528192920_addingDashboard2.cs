using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESST6.Migrations
{
    /// <inheritdoc />
    public partial class addingDashboard2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Dashboards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Dashboards_UserId",
                table: "Dashboards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dashboards_AspNetUsers_UserId",
                table: "Dashboards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dashboards_AspNetUsers_UserId",
                table: "Dashboards");

            migrationBuilder.DropIndex(
                name: "IX_Dashboards_UserId",
                table: "Dashboards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Dashboards");
        }
    }
}
