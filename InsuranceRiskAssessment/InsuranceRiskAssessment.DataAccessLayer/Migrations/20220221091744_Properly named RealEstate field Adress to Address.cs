using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    public partial class ProperlynamedRealEstatefieldAdresstoAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "VillaBuildings",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "ResidentialBuildings",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "CommercialProperties",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Adress",
                table: "BusinessEnterprises",
                newName: "Address");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "VillaBuildings",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "ResidentialBuildings",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "CommercialProperties",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "BusinessEnterprises",
                newName: "Adress");
        }
    }
}
