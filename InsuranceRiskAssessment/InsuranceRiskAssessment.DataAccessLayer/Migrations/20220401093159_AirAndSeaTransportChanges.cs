using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    public partial class AirAndSeaTransportChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClimatZone",
                table: "SeaTransports",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ClimatZone",
                table: "AirTransports",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
