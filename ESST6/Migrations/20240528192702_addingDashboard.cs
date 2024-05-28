using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ESST6.Migrations
{
    /// <inheritdoc />
    public partial class addingDashboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dashboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StansiyaAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceBatteryPercent = table.Column<double>(type: "float", nullable: false),
                    SolarBatteryPercent = table.Column<double>(type: "float", nullable: false),
                    CurrentTemp = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dashboards", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dashboards");
        }
    }
}
