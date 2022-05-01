using Microsoft.EntityFrameworkCore.Migrations;

namespace InsuranceRiskAssessment.DataAccessLayer.Migrations
{
    public partial class RefactorBroker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "VillaBuildings",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_VillaBuildings_InsuranceBrokerId",
                table: "VillaBuildings",
                newName: "IX_VillaBuildings_InsuranceBrokerUserId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "VehiclesByLand",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclesByLand_InsuranceBrokerId",
                table: "VehiclesByLand",
                newName: "IX_VehiclesByLand_InsuranceBrokerUserId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "SeaTransports",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_SeaTransports_InsuranceBrokerId",
                table: "SeaTransports",
                newName: "IX_SeaTransports_InsuranceBrokerUserId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "ResidentialBuildings",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentialBuildings_InsuranceBrokerId",
                table: "ResidentialBuildings",
                newName: "IX_ResidentialBuildings_InsuranceBrokerUserId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "CommercialProperties",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_CommercialProperties_InsuranceBrokerId",
                table: "CommercialProperties",
                newName: "IX_CommercialProperties_InsuranceBrokerUserId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerId",
                table: "BusinessEnterprises",
                newName: "InsuranceBrokerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessEnterprises_InsuranceBrokerId",
                table: "BusinessEnterprises",
                newName: "IX_BusinessEnterprises_InsuranceBrokerUserId");

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "VillaBuildings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "VehiclesByLand",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "SeaTransports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "ResidentialBuildings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "CommercialProperties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InsuranceBroker",
                table: "BusinessEnterprises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BusinessEnterprises_AspNetUsers_InsuranceBrokerUserId",
                table: "BusinessEnterprises",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommercialProperties_AspNetUsers_InsuranceBrokerUserId",
                table: "CommercialProperties",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentialBuildings_AspNetUsers_InsuranceBrokerUserId",
                table: "ResidentialBuildings",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SeaTransports_AspNetUsers_InsuranceBrokerUserId",
                table: "SeaTransports",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehiclesByLand_AspNetUsers_InsuranceBrokerUserId",
                table: "VehiclesByLand",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VillaBuildings_AspNetUsers_InsuranceBrokerUserId",
                table: "VillaBuildings",
                column: "InsuranceBrokerUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BusinessEnterprises_AspNetUsers_InsuranceBrokerUserId",
                table: "BusinessEnterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_CommercialProperties_AspNetUsers_InsuranceBrokerUserId",
                table: "CommercialProperties");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentialBuildings_AspNetUsers_InsuranceBrokerUserId",
                table: "ResidentialBuildings");

            migrationBuilder.DropForeignKey(
                name: "FK_SeaTransports_AspNetUsers_InsuranceBrokerUserId",
                table: "SeaTransports");

            migrationBuilder.DropForeignKey(
                name: "FK_VehiclesByLand_AspNetUsers_InsuranceBrokerUserId",
                table: "VehiclesByLand");

            migrationBuilder.DropForeignKey(
                name: "FK_VillaBuildings_AspNetUsers_InsuranceBrokerUserId",
                table: "VillaBuildings");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "VillaBuildings");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "VehiclesByLand");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "SeaTransports");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "ResidentialBuildings");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "CommercialProperties");

            migrationBuilder.DropColumn(
                name: "InsuranceBroker",
                table: "BusinessEnterprises");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "VillaBuildings",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_VillaBuildings_InsuranceBrokerUserId",
                table: "VillaBuildings",
                newName: "IX_VillaBuildings_InsuranceBrokerId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "VehiclesByLand",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_VehiclesByLand_InsuranceBrokerUserId",
                table: "VehiclesByLand",
                newName: "IX_VehiclesByLand_InsuranceBrokerId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "SeaTransports",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_SeaTransports_InsuranceBrokerUserId",
                table: "SeaTransports",
                newName: "IX_SeaTransports_InsuranceBrokerId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "ResidentialBuildings",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentialBuildings_InsuranceBrokerUserId",
                table: "ResidentialBuildings",
                newName: "IX_ResidentialBuildings_InsuranceBrokerId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "CommercialProperties",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_CommercialProperties_InsuranceBrokerUserId",
                table: "CommercialProperties",
                newName: "IX_CommercialProperties_InsuranceBrokerId");

            migrationBuilder.RenameColumn(
                name: "InsuranceBrokerUserId",
                table: "BusinessEnterprises",
                newName: "InsuranceBrokerId");

            migrationBuilder.RenameIndex(
                name: "IX_BusinessEnterprises_InsuranceBrokerUserId",
                table: "BusinessEnterprises",
                newName: "IX_BusinessEnterprises_InsuranceBrokerId");

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
    }
}
