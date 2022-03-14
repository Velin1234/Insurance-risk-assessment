using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    public partial class InsuranceBrokerUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "VillaBuildings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "VehiclesByLand",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "SeaTransports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "ResidentialBuildings",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "CommercialProperties",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "BusinessEnterprises",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBrokerId",
                table: "AirTransports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VillaBuildings_InsuranceBrokerId",
                table: "VillaBuildings",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_VehiclesByLand_InsuranceBrokerId",
                table: "VehiclesByLand",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_SeaTransports_InsuranceBrokerId",
                table: "SeaTransports",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialBuildings_InsuranceBrokerId",
                table: "ResidentialBuildings",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialProperties_InsuranceBrokerId",
                table: "CommercialProperties",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessEnterprises_InsuranceBrokerId",
                table: "BusinessEnterprises",
                column: "InsuranceBrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_AirTransports_InsuranceBrokerId",
                table: "AirTransports",
                column: "InsuranceBrokerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AirTransports_AspNetUsers_InsuranceBrokerId",
                table: "AirTransports",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEnterprises_AspNetUsers_InsuranceBrokerId",
                table: "BusinessEnterprises",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialProperties_AspNetUsers_InsuranceBrokerId",
                table: "CommercialProperties",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentialBuildings_AspNetUsers_InsuranceBrokerId",
                table: "ResidentialBuildings",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeaTransports_AspNetUsers_InsuranceBrokerId",
                table: "SeaTransports",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclesByLand_AspNetUsers_InsuranceBrokerId",
                table: "VehiclesByLand",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VillaBuildings_AspNetUsers_InsuranceBrokerId",
                table: "VillaBuildings",
                column: "InsuranceBrokerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirTransports_AspNetUsers_InsuranceBrokerId",
                table: "AirTransports");

            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEnterprises_AspNetUsers_InsuranceBrokerId",
                table: "BusinessEnterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_CommercialProperties_AspNetUsers_InsuranceBrokerId",
                table: "CommercialProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentialBuildings_AspNetUsers_InsuranceBrokerId",
                table: "ResidentialBuildings");

            migrationBuilder.DropForeignKey(
                name: "FK_SeaTransports_AspNetUsers_InsuranceBrokerId",
                table: "SeaTransports");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclesByLand_AspNetUsers_InsuranceBrokerId",
                table: "VehiclesByLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VillaBuildings_AspNetUsers_InsuranceBrokerId",
                table: "VillaBuildings");

            migrationBuilder.DropIndex(
                name: "IX_VillaBuildings_InsuranceBrokerId",
                table: "VillaBuildings");

            migrationBuilder.DropIndex(
                name: "IX_VehiclesByLand_InsuranceBrokerId",
                table: "VehiclesByLand");

            migrationBuilder.DropIndex(
                name: "IX_SeaTransports_InsuranceBrokerId",
                table: "SeaTransports");

            migrationBuilder.DropIndex(
                name: "IX_ResidentialBuildings_InsuranceBrokerId",
                table: "ResidentialBuildings");

            migrationBuilder.DropIndex(
                name: "IX_CommercialProperties_InsuranceBrokerId",
                table: "CommercialProperties");

            migrationBuilder.DropIndex(
                name: "IX_BusinessEnterprises_InsuranceBrokerId",
                table: "BusinessEnterprises");

            migrationBuilder.DropIndex(
                name: "IX_AirTransports_InsuranceBrokerId",
                table: "AirTransports");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "VillaBuildings");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "VehiclesByLand");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "SeaTransports");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "ResidentialBuildings");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "CommercialProperties");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "BusinessEnterprises");

            migrationBuilder.DropColumn(
                name: "InsuranceBrokerId",
                table: "AirTransports");
        }
    }
}
